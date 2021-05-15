using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using Version = Lucene.Net.Util.Version;

namespace AdopseAddsTeam5.GUI.Main_Form
{
    class LuceneSearch
    {
        public static int total_hits = 0;
        static string enviroment = System.Environment.CurrentDirectory;
        static string projectDirectory = System.IO.Directory.GetParent(enviroment).Parent.FullName;
        private static string _luceneDir = Path.Combine(projectDirectory, "lucene_index");
        private static FSDirectory _directoryTemp;

        //public static IndexWriter writer;

        private static FSDirectory _directory
        {
            get
            {
                if (_directoryTemp == null) _directoryTemp = FSDirectory.Open(new DirectoryInfo(_luceneDir));
                if (IndexWriter.IsLocked(_directoryTemp)) IndexWriter.Unlock(_directoryTemp);
                var lockFilePath = Path.Combine(_luceneDir, "write.lock");
                if (File.Exists(lockFilePath)) File.Delete(lockFilePath);
                return _directoryTemp;
            }
        }

        private static void _addToLuceneIndex(Adds sampleData, IndexWriter writer)
        {
            // remove older index entry
            var searchQuery = new TermQuery(new Term("sid", sampleData.sid.ToString()));
            writer.DeleteDocuments(searchQuery);

            // add new index entry
            var doc = new Document();

            // add lucene fields mapped to db fields
            doc.Add(new Field("sid", sampleData.sid.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("perioxi", sampleData.perioxi, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("typos_akinitou", sampleData.title, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("typos_aggelias", sampleData.eidos, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("mpanio", sampleData.mpanio.ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("ypnodomatia", sampleData.ypnodomatia.ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("emvadon", sampleData.emvadon.ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("timi", sampleData.timi.ToString(), Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("perigrafi", sampleData.desc, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("email", sampleData.email, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("thlefwno", sampleData.phone, Field.Store.YES, Field.Index.NOT_ANALYZED));
            doc.Add(new Field("systhma_thermanshs", sampleData.thermansi, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("dieuthinsi", sampleData.dieuthinsi, Field.Store.YES, Field.Index.ANALYZED));
            doc.Add(new Field("photos", sampleData.photonumber.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

            // add entry to index
            writer.AddDocument(doc);
        }

        public static void AddUpdateLuceneIndex(IEnumerable<Adds> sampleDatas)
        {
            // init lucene
            var analyzer = new StandardAnalyzer(Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                // add data to lucene search index (replaces older entry if any)
                foreach (var sampleData in sampleDatas) _addToLuceneIndex(sampleData, writer);

                // close handles
                analyzer.Close();
                writer.Dispose();
            }
        }

        public static void AddUpdateLuceneIndex(Adds sampleData)
        {
            AddUpdateLuceneIndex(new List<Adds> { sampleData });
        }

        //gia diagrafi single record
        public static void ClearLuceneIndexRecord(int record_sid)
        {
            // init lucene
            var analyzer = new StandardAnalyzer(Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                // remove older index entry
                var searchQuery = new TermQuery(new Term("sid", record_sid.ToString()));
                writer.DeleteDocuments(searchQuery);

                // close handles
                analyzer.Close();
                writer.Dispose();
            }
        }

        //gia diagrafi olon ton index records
        public static bool ClearLuceneIndex()
        {
            try
            {
                var analyzer = new StandardAnalyzer(Version.LUCENE_30);
                using (var writer = new IndexWriter(_directory, analyzer, true, IndexWriter.MaxFieldLength.UNLIMITED))
                {
                    // remove older index entries
                    writer.DeleteAll();

                    // close handles
                    analyzer.Close();
                    writer.Dispose();
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //gia kalytero optimization 
        public static void Optimize()
        {
            var analyzer = new StandardAnalyzer(Version.LUCENE_30);
            using (var writer = new IndexWriter(_directory, analyzer, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                analyzer.Close();
                writer.Optimize();
                writer.Dispose();
            }
        }

        //gia mapping
        private static Adds _mapLuceneDocumentToData(Document doc)
        {
            return new Adds
            {
                sid = Convert.ToInt32(doc.Get("id")),
                title = doc.Get("typos_akinitou"),
                perioxi = doc.Get("perioxi"),
                eidos = doc.Get("typos_aggelias"),
                mpanio = Convert.ToInt32(doc.Get("mpanio")),
                ypnodomatia = Convert.ToInt32(doc.Get("ypnodomatia")),
                emvadon = Convert.ToInt32(doc.Get("emvadon")),
                timi = Convert.ToInt32(doc.Get("timi")),
                email = doc.Get("email"),
                desc = doc.Get("perigrafi"),
                phone = doc.Get("thlefwno"),
                thermansi = doc.Get("systhma_thermanshs"),
                photonumber = Convert.ToInt32(doc.Get("photos")),
                dieuthinsi = doc.Get("dieuthinsi")
            };
        }

        //gia allou idous mapping
        private static IEnumerable<Adds> _mapLuceneToDataList(IEnumerable<Document> hits)
        {
            return hits.Select(_mapLuceneDocumentToData).ToList();
        }
        private static IEnumerable<Adds> _mapLuceneToDataList(IEnumerable<ScoreDoc> hits,
            IndexSearcher searcher)
        {
            return hits.Select(hit => _mapLuceneDocumentToData(searcher.Doc(hit.Doc))).ToList();
        }



        //MAIN SEARCH METHODS *=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*=*

        //auti einai gia na kanei parse to query string pou tha tis dosoume
        private static Query parseQuery(string searchQuery, QueryParser parser)
        {
            Query query;
            try
            {
                query = parser.Parse(searchQuery.Trim());
            }
            catch (ParseException)
            {
                query = parser.Parse(QueryParser.Escape(searchQuery.Trim()));
            }
            return query;
        }

        //kai edo ginonte ta thaumata
        private static IEnumerable<Adds> _search
            (string searchQuery)
        {
            // validation
            if (string.IsNullOrEmpty(searchQuery.Replace("*", "").Replace("?", ""))) return new List<Adds>();

            // set up lucene searcher
            using (var searcher = new IndexSearcher(_directory, false))
            {
                var hits_limit = 1000;
                var analyzer = new StandardAnalyzer(Version.LUCENE_30);

                
                    var parser = new MultiFieldQueryParser
                        (Version.LUCENE_30, new[] { "perioxi", "typos_akinitou", "typos_aggelias", "mpanio", "ypnodomatia", "emvadon", "timi", "dieuthinsi" }, analyzer);
                    var query = parseQuery(searchQuery, parser);
                    var hits = searcher.Search
                    (query, null, hits_limit, Sort.RELEVANCE).ScoreDocs;
                    var results = _mapLuceneToDataList(hits, searcher);
                    total_hits = hits.Length;
                    analyzer.Close();
                    searcher.Dispose();
                    return results;
                
            }
        }

        // auti ti methodo tha kaloume gia to koumpi ANAZITISI ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static IEnumerable<Adds> Search(string input)
        {
            if (string.IsNullOrEmpty(input)) return new List<Adds>();

            var terms = input.Trim().Replace("-", " ").Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
            input = string.Join(" ", terms);

            return _search(input);
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        // auti gia to koumpi AGORA  
        public static IEnumerable<Adds> SearchBuy(string input)
        {
            if (string.IsNullOrEmpty(input)) return new List<Adds>();

            var terms = input.Trim().Replace("-", " ").Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
            input = string.Join(" ", terms);
            List<Adds> buyadds = _search(input).ToList();
            buyadds.RemoveAll(p => p.eidos == "Ενοικίαση");
            return  buyadds;
        }

        

        //auti gia to koumpi ENOIKIASI
        public static IEnumerable<Adds> SearchRent(string input)
        {
            if (string.IsNullOrEmpty(input)) return new List<Adds>();

            var terms = input.Trim().Replace("-", " ").Split(' ')
                .Where(x => !string.IsNullOrEmpty(x)).Select(x => x.Trim() + "*");
            input = string.Join(" ", terms);
            List<Adds> rentadds = _search(input).ToList();
            rentadds.RemoveAll(p => p.eidos == "Αγορά");
            return rentadds;
        }

        
    }
}
