-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 9.1.24lts2
-- Dumped by pg_dump version 9.5.5

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

SET search_path = it164760, pg_catalog;

ALTER TABLE ONLY it164760.user_pass DROP CONSTRAINT users_email;
ALTER TABLE ONLY it164760.messages1 DROP CONSTRAINT m_email;
ALTER TABLE ONLY it164760.messages DROP CONSTRAINT m_email;
ALTER TABLE ONLY it164760.images_aggelies DROP CONSTRAINT i_id;
ALTER TABLE ONLY it164760.agapimena DROP CONSTRAINT a_id;
ALTER TABLE ONLY it164760.agapimena DROP CONSTRAINT a_email;
DROP TRIGGER status1 ON it164760.messages1;
DROP TRIGGER message_notification ON it164760.messages;
ALTER TABLE ONLY it164760.users DROP CONSTRAINT users_pkey;
ALTER TABLE ONLY it164760.users1 DROP CONSTRAINT users1_pkey;
ALTER TABLE ONLY it164760.user_pass DROP CONSTRAINT user_pass_pkey;
ALTER TABLE ONLY it164760.test DROP CONSTRAINT test_pkey;
ALTER TABLE ONLY it164760.test1 DROP CONSTRAINT test1_pkey;
ALTER TABLE ONLY it164760.messages1 DROP CONSTRAINT messages1_pkey;
ALTER TABLE ONLY it164760.images_aggelies DROP CONSTRAINT images_aggelies_pkey;
ALTER TABLE ONLY it164760.aggelies1 DROP CONSTRAINT aggelies1_pkey;
ALTER TABLE ONLY it164760.agapimena DROP CONSTRAINT agapimena_pkey;
SELECT pg_catalog.lo_unlink('580326');
SELECT pg_catalog.lo_unlink('580312');
SELECT pg_catalog.lo_unlink('576166');
SELECT pg_catalog.lo_unlink('43213');
ALTER TABLE it164760.test1 ALTER COLUMN id DROP DEFAULT;
ALTER TABLE it164760.test ALTER COLUMN id DROP DEFAULT;
ALTER TABLE it164760.messages1 ALTER COLUMN id DROP DEFAULT;
ALTER TABLE it164760.aggelies1 ALTER COLUMN id DROP DEFAULT;
DROP TABLE it164760.test_image;
DROP SEQUENCE it164760.test_id_seq;
DROP SEQUENCE it164760.test1_id_seq;
DROP TABLE it164760.test1;
DROP TABLE it164760.test;
DROP SEQUENCE it164760.messages1_table;
DROP SEQUENCE it164760.messages1_id_seq;
DROP TABLE it164760.images_aggelies;
DROP SEQUENCE it164760.id_aggelies1;
DROP SEQUENCE it164760.id_aggelies;
DROP SEQUENCE it164760.aggelies1_id_seq;
DROP TABLE it164760.agapimena;
DROP FUNCTION it164760.theadd(integer);
DROP FUNCTION it164760.show_users();
DROP TABLE it164760.users;
DROP FUNCTION it164760.show_user_pass();
DROP TABLE it164760.user_pass;
DROP FUNCTION it164760.show_message1(character varying);
DROP TABLE it164760.messages1;
DROP FUNCTION it164760.show_message(character varying);
DROP TABLE it164760.messages;
DROP FUNCTION it164760.show_aggelies1();
DROP FUNCTION it164760.show_aggelies();
DROP FUNCTION it164760.show_agapimena(character varying);
DROP FUNCTION it164760.return_aggelies(character varying);
DROP TABLE it164760.aggelies1;
DROP FUNCTION it164760.read_notification(character varying);
DROP FUNCTION it164760.log_in(character varying, character varying);
DROP TABLE it164760.users1;
DROP FUNCTION it164760.insert_usersname(character varying, character varying);
DROP FUNCTION it164760.insert_users2(character varying, character varying);
DROP FUNCTION it164760.insert_users1(character varying, character varying);
DROP FUNCTION it164760.insert_users(character varying, character varying, character varying, character varying);
DROP FUNCTION it164760.insert_user_pass(character varying, character varying, character varying);
DROP FUNCTION it164760.insert_newemail(character varying, character varying);
DROP FUNCTION it164760.insert_message1(character varying, character varying, character varying, character varying, character varying, character varying);
DROP FUNCTION it164760.insert_message(character varying, character varying, character varying, character varying, character varying);
DROP FUNCTION it164760.insert_aggelies_final(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying, character varying);
DROP FUNCTION it164760.insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying);
DROP FUNCTION it164760.insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer);
DROP FUNCTION it164760.insert_aggelies(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer);
DROP FUNCTION it164760.insert_agapimena(character varying, integer);
DROP FUNCTION it164760.delete_users(character varying);
DROP FUNCTION it164760.delete_message1(integer);
DROP FUNCTION it164760.delete_message(integer);
DROP FUNCTION it164760.delete_aggelies1(integer);
DROP FUNCTION it164760.change_users1_status();
DROP FUNCTION it164760.change_status();
DROP FUNCTION it164760.change_image(character varying, character varying);
DROP FUNCTION it164760.aggelies_filtra(integer, integer, integer, integer, integer, integer, integer, integer);
DROP TABLE it164760.aggelies;
DROP EXTENSION plpgsql;
DROP SCHEMA it164760;
--
-- Name: it164760; Type: SCHEMA; Schema: -; Owner: it164760
--

CREATE SCHEMA it164760;


ALTER SCHEMA it164760 OWNER TO it164760;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = it164760, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: aggelies; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE aggelies (
    perioxi character varying(60),
    timi integer,
    typos_aggelias character varying(30),
    emvado integer,
    typos_akinitou character varying(30),
    systhma_thermanshs character varying(30),
    thlefwno character varying(30),
    perigrafi character varying(1000),
    mpania integer,
    ypnodwmatia integer
);


ALTER TABLE aggelies OWNER TO it164760;

--
-- Name: aggelies_filtra(integer, integer, integer, integer, integer, integer, integer, integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION aggelies_filtra(integer, integer, integer, integer, integer, integer, integer, integer) RETURNS SETOF aggelies
    LANGUAGE sql
    AS $_$

 select * from aggelies
where timi>=$1 and timi<=$2 and emvado>=$3 and emvado<=$4 and ypnodwmatia>=$5 and ypnodwmatia<=$6 and mpania>=$7 and mpania<=$8
$_$;


ALTER FUNCTION it164760.aggelies_filtra(integer, integer, integer, integer, integer, integer, integer, integer) OWNER TO it164760;

--
-- Name: change_image(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION change_image(character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
  update users1 set picture=$2 where email=$1;
  $_$;


ALTER FUNCTION it164760.change_image(character varying, character varying) OWNER TO it164760;

--
-- Name: change_status(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION change_status() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
IF(TG_OP='INSERT')THEN
UPDATE USERS SET STATUS=1 where email=NEW.email;
END IF;
RETURN NULL;
END;
$$;


ALTER FUNCTION it164760.change_status() OWNER TO it164760;

--
-- Name: change_users1_status(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION change_users1_status() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
IF(TG_OP='INSERT')THEN
UPDATE users1 SET STATUS=1 where email=NEW.email;
END IF;
RETURN NULL;
END;
$$;


ALTER FUNCTION it164760.change_users1_status() OWNER TO it164760;

--
-- Name: delete_aggelies1(integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION delete_aggelies1(integer) RETURNS void
    LANGUAGE sql
    AS $_$
	delete from aggelies1 where id=$1;
$_$;


ALTER FUNCTION it164760.delete_aggelies1(integer) OWNER TO it164760;

--
-- Name: delete_message(integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION delete_message(integer) RETURNS void
    LANGUAGE sql
    AS $_$
delete from messages1 where id=$1
  $_$;


ALTER FUNCTION it164760.delete_message(integer) OWNER TO it164760;

--
-- Name: delete_message1(integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION delete_message1(integer) RETURNS void
    LANGUAGE sql
    AS $_$
delete from messages1 where id=$1
  $_$;


ALTER FUNCTION it164760.delete_message1(integer) OWNER TO it164760;

--
-- Name: delete_users(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION delete_users(character varying) RETURNS void
    LANGUAGE sql
    AS $_$
delete from users where email=$1
$_$;


ALTER FUNCTION it164760.delete_users(character varying) OWNER TO it164760;

--
-- Name: insert_agapimena(character varying, integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_agapimena(character varying, integer) RETURNS void
    LANGUAGE sql
    AS $_$
  insert into agapimena(email,id) values($1,$2);
  $_$;


ALTER FUNCTION it164760.insert_agapimena(character varying, integer) OWNER TO it164760;

--
-- Name: insert_aggelies(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_aggelies(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer) RETURNS void
    LANGUAGE sql
    AS $_$
insert into aggelies(perioxi,timi,typos_aggelias,emvado,typos_akinitou,systhma_thermanshs,thlefwno,perigrafi,mpania,ypnodwmatia) values ($1,$2,$3,$4,$5,$6,$7,$8,$9,$10)
$_$;


ALTER FUNCTION it164760.insert_aggelies(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer) OWNER TO it164760;

--
-- Name: insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer) RETURNS void
    LANGUAGE sql
    AS $_$
  insert into aggelies1(id,perioxi,timi,typos_aggelias,emvadon,typos_akinitou,systhma_thermanshs,thlefwno,perigrafi,mpania,ypnodwmatia)values(nextval('id_aggelies1'),$1,$2,$3,$4,$5,$6,$7,$8,$9,$10);
  $_$;


ALTER FUNCTION it164760.insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer) OWNER TO it164760;

--
-- Name: insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
  insert into aggelies1(id,perioxi,timi,typos_aggelias,emvadon,typos_akinitou,systhma_thermanshs,thlefwno,perigrafi,mpania,ypnodwmatia,email)values(nextval('id_aggelies1'),$1,$2,$3,$4,$5,$6,$7,$8,$9,$10,$11);
  $_$;


ALTER FUNCTION it164760.insert_aggelies1(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying) OWNER TO it164760;

--
-- Name: insert_aggelies_final(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_aggelies_final(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into aggelies1(id,perioxi,timi,typos_aggelias,emvadon,typos_akinitou,systhma_thermanshs,thlefwno,perigrafi,mpania,ypnodwmatia,email,dieythinsi)values(nextval('id_aggelies1'),$1,$2,$3,$4,$5,$6,$7,$8,$9,$10,$11,$12);
$_$;


ALTER FUNCTION it164760.insert_aggelies_final(character varying, integer, character varying, integer, character varying, character varying, character varying, character varying, integer, integer, character varying, character varying) OWNER TO it164760;

--
-- Name: insert_message(character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_message(character varying, character varying, character varying, character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into messages(name,surname,phone_number,email,text) values ($1,$2,$3,$4,$5);
$_$;


ALTER FUNCTION it164760.insert_message(character varying, character varying, character varying, character varying, character varying) OWNER TO it164760;

--
-- Name: insert_message1(character varying, character varying, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_message1(character varying, character varying, character varying, character varying, character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
  insert into messages1(name,surname,phone_number,email,text,id,email2)values($1,$2,$3,$4,$5,nextval('messages1_table'),$6)
  $_$;


ALTER FUNCTION it164760.insert_message1(character varying, character varying, character varying, character varying, character varying, character varying) OWNER TO it164760;

--
-- Name: insert_newemail(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_newemail(character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
update users1 set email=$2
where email=$1;
$_$;


ALTER FUNCTION it164760.insert_newemail(character varying, character varying) OWNER TO it164760;

--
-- Name: insert_user_pass(character varying, character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_user_pass(character varying, character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into user_pass(nickname,password,email) values ($1,$2,$3)
$_$;


ALTER FUNCTION it164760.insert_user_pass(character varying, character varying, character varying) OWNER TO it164760;

--
-- Name: insert_users(character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_users(character varying, character varying, character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into users(name,surname,email,phone_number,status) values ($1,$2,$3,$4,0);
$_$;


ALTER FUNCTION it164760.insert_users(character varying, character varying, character varying, character varying) OWNER TO it164760;

--
-- Name: insert_users1(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_users1(character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into users1 (onoma_epwnymo,picture,email,kwdikos,status) values(' ',' ',$1,$2,0);
  $_$;


ALTER FUNCTION it164760.insert_users1(character varying, character varying) OWNER TO it164760;

--
-- Name: insert_users2(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_users2(character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
insert into users1 values(' ',$1,$2,0,' ');
$_$;


ALTER FUNCTION it164760.insert_users2(character varying, character varying) OWNER TO it164760;

--
-- Name: insert_usersname(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION insert_usersname(character varying, character varying) RETURNS void
    LANGUAGE sql
    AS $_$
  update users1 set onoma_epwnymo=$2 where email=$1;
  $_$;


ALTER FUNCTION it164760.insert_usersname(character varying, character varying) OWNER TO it164760;

--
-- Name: users1; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE users1 (
    onoma_epwnymo character varying(50),
    email character varying(60) NOT NULL,
    kwdikos character varying(20) NOT NULL,
    status integer,
    picture character varying(100000)
);


ALTER TABLE users1 OWNER TO it164760;

--
-- Name: log_in(character varying, character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION log_in(character varying, character varying) RETURNS SETOF users1
    LANGUAGE sql
    AS $_$
select * from users1 where email=$1 and kwdikos=$2
$_$;


ALTER FUNCTION it164760.log_in(character varying, character varying) OWNER TO it164760;

--
-- Name: read_notification(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION read_notification(character varying) RETURNS void
    LANGUAGE sql
    AS $_$
update users set status=0 where email=$1
$_$;


ALTER FUNCTION it164760.read_notification(character varying) OWNER TO it164760;

--
-- Name: aggelies1; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE aggelies1 (
    id integer NOT NULL,
    perioxi character varying(60),
    timi integer,
    typos_aggelias character varying(30),
    emvadon integer,
    typos_akinitou character varying(50),
    systhma_thermanshs character varying(30),
    thlefwno character varying(30),
    perigrafi character varying(1000),
    mpania integer,
    ypnodwmatia integer,
    email character varying(60),
    photo integer DEFAULT 0 NOT NULL,
    dieythinsi character varying(50) DEFAULT ''::character varying NOT NULL
);


ALTER TABLE aggelies1 OWNER TO it164760;

--
-- Name: return_aggelies(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION return_aggelies(character varying) RETURNS SETOF aggelies1
    LANGUAGE sql
    AS $_$
	select * from aggelies1 where email=$1
$_$;


ALTER FUNCTION it164760.return_aggelies(character varying) OWNER TO it164760;

--
-- Name: show_agapimena(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_agapimena(character varying) RETURNS SETOF aggelies1
    LANGUAGE sql
    AS $_$
  select distinct a.id,a.perioxi,a.timi,a.typos_aggelias,a.emvadon,a.typos_akinitou,a.systhma_thermanshs,a.thlefwno,a.perigrafi,a.mpania,a.ypnodwmatia,a.email from aggelies1 a inner join agapimena a1 on a.id=a1.id
where a1.email=$1
  $_$;


ALTER FUNCTION it164760.show_agapimena(character varying) OWNER TO it164760;

--
-- Name: show_aggelies(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_aggelies() RETURNS SETOF aggelies
    LANGUAGE sql
    AS $$
SELECT * FROM aggelies;
$$;


ALTER FUNCTION it164760.show_aggelies() OWNER TO it164760;

--
-- Name: show_aggelies1(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_aggelies1() RETURNS SETOF aggelies1
    LANGUAGE sql
    AS $$
  select * from aggelies1 ;
  $$;


ALTER FUNCTION it164760.show_aggelies1() OWNER TO it164760;

--
-- Name: messages; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE messages (
    name character varying(30),
    surname character varying(30),
    phone_number character varying(20),
    email character varying(30),
    text character varying(10000)
);


ALTER TABLE messages OWNER TO it164760;

--
-- Name: show_message(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_message(character varying) RETURNS SETOF messages
    LANGUAGE sql
    AS $_$
select * from messages where email=$1
$_$;


ALTER FUNCTION it164760.show_message(character varying) OWNER TO it164760;

--
-- Name: messages1; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE messages1 (
    name character varying(30),
    surname character varying(30),
    phone_number character varying(20),
    email character varying(30),
    text character varying(10000),
    id integer NOT NULL,
    email2 character varying(30)
);


ALTER TABLE messages1 OWNER TO it164760;

--
-- Name: show_message1(character varying); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_message1(character varying) RETURNS SETOF messages1
    LANGUAGE sql
    AS $_$
  select * from messages1 where email=$1
  $_$;


ALTER FUNCTION it164760.show_message1(character varying) OWNER TO it164760;

--
-- Name: user_pass; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE user_pass (
    nickname character varying(20) NOT NULL,
    password character varying(128) NOT NULL,
    email character varying(30) NOT NULL
);


ALTER TABLE user_pass OWNER TO it164760;

--
-- Name: show_user_pass(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_user_pass() RETURNS SETOF user_pass
    LANGUAGE sql
    AS $$
SELECT * FROM user_pass;
$$;


ALTER FUNCTION it164760.show_user_pass() OWNER TO it164760;

--
-- Name: users; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE users (
    name character varying(20),
    surname character varying(20),
    email character varying(30) NOT NULL,
    phone_number character varying(30),
    status integer
);


ALTER TABLE users OWNER TO it164760;

--
-- Name: show_users(); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION show_users() RETURNS SETOF users
    LANGUAGE sql
    AS $$
SELECT * FROM users;
$$;


ALTER FUNCTION it164760.show_users() OWNER TO it164760;

--
-- Name: theadd(integer); Type: FUNCTION; Schema: it164760; Owner: it164760
--

CREATE FUNCTION theadd(integer) RETURNS SETOF aggelies1
    LANGUAGE sql
    AS $_$
  select * from aggelies1 where id=$1;
  $_$;


ALTER FUNCTION it164760.theadd(integer) OWNER TO it164760;

--
-- Name: agapimena; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE agapimena (
    email character varying(60) NOT NULL,
    id integer NOT NULL
);


ALTER TABLE agapimena OWNER TO it164760;

--
-- Name: aggelies1_id_seq; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE aggelies1_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE aggelies1_id_seq OWNER TO it164760;

--
-- Name: aggelies1_id_seq; Type: SEQUENCE OWNED BY; Schema: it164760; Owner: it164760
--

ALTER SEQUENCE aggelies1_id_seq OWNED BY aggelies1.id;


--
-- Name: id_aggelies; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE id_aggelies
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE id_aggelies OWNER TO it164760;

--
-- Name: id_aggelies1; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE id_aggelies1
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE id_aggelies1 OWNER TO it164760;

--
-- Name: images_aggelies; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE images_aggelies (
    id integer NOT NULL,
    email character varying(60)
);


ALTER TABLE images_aggelies OWNER TO it164760;

--
-- Name: messages1_id_seq; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE messages1_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE messages1_id_seq OWNER TO it164760;

--
-- Name: messages1_id_seq; Type: SEQUENCE OWNED BY; Schema: it164760; Owner: it164760
--

ALTER SEQUENCE messages1_id_seq OWNED BY messages1.id;


--
-- Name: messages1_table; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE messages1_table
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE messages1_table OWNER TO it164760;

--
-- Name: test; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE test (
    id integer NOT NULL,
    er integer,
    re integer
);


ALTER TABLE test OWNER TO it164760;

--
-- Name: test1; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE test1 (
    id integer NOT NULL,
    er integer,
    re integer
);


ALTER TABLE test1 OWNER TO it164760;

--
-- Name: test1_id_seq; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE test1_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE test1_id_seq OWNER TO it164760;

--
-- Name: test1_id_seq; Type: SEQUENCE OWNED BY; Schema: it164760; Owner: it164760
--

ALTER SEQUENCE test1_id_seq OWNED BY test1.id;


--
-- Name: test_id_seq; Type: SEQUENCE; Schema: it164760; Owner: it164760
--

CREATE SEQUENCE test_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE test_id_seq OWNER TO it164760;

--
-- Name: test_id_seq; Type: SEQUENCE OWNED BY; Schema: it164760; Owner: it164760
--

ALTER SEQUENCE test_id_seq OWNED BY test.id;


--
-- Name: test_image; Type: TABLE; Schema: it164760; Owner: it164760
--

CREATE TABLE test_image (
    name text,
    raster oid
);


ALTER TABLE test_image OWNER TO it164760;

--
-- Name: id; Type: DEFAULT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY aggelies1 ALTER COLUMN id SET DEFAULT nextval('aggelies1_id_seq'::regclass);


--
-- Name: id; Type: DEFAULT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY messages1 ALTER COLUMN id SET DEFAULT nextval('messages1_id_seq'::regclass);


--
-- Name: id; Type: DEFAULT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY test ALTER COLUMN id SET DEFAULT nextval('test_id_seq'::regclass);


--
-- Name: id; Type: DEFAULT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY test1 ALTER COLUMN id SET DEFAULT nextval('test1_id_seq'::regclass);


--
-- Name: 43213; Type: BLOB; Schema: -; Owner: it164760
--

SELECT pg_catalog.lo_create('43213');


ALTER LARGE OBJECT 43213 OWNER TO it164760;

--
-- Name: 576166; Type: BLOB; Schema: -; Owner: it164760
--

SELECT pg_catalog.lo_create('576166');


ALTER LARGE OBJECT 576166 OWNER TO it164760;

--
-- Name: 580312; Type: BLOB; Schema: -; Owner: it164760
--

SELECT pg_catalog.lo_create('580312');


ALTER LARGE OBJECT 580312 OWNER TO it164760;

--
-- Name: 580326; Type: BLOB; Schema: -; Owner: it164760
--

SELECT pg_catalog.lo_create('580326');


ALTER LARGE OBJECT 580326 OWNER TO it164760;

--
-- Data for Name: agapimena; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY agapimena (email, id) FROM stdin;
\.
COPY agapimena (email, id) FROM '$$PATH$$/1993.dat';

--
-- Data for Name: aggelies; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY aggelies (perioxi, timi, typos_aggelias, emvado, typos_akinitou, systhma_thermanshs, thlefwno, perigrafi, mpania, ypnodwmatia) FROM stdin;
\.
COPY aggelies (perioxi, timi, typos_aggelias, emvado, typos_akinitou, systhma_thermanshs, thlefwno, perigrafi, mpania, ypnodwmatia) FROM '$$PATH$$/1980.dat';

--
-- Data for Name: aggelies1; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY aggelies1 (id, perioxi, timi, typos_aggelias, emvadon, typos_akinitou, systhma_thermanshs, thlefwno, perigrafi, mpania, ypnodwmatia, email, photo, dieythinsi) FROM stdin;
\.
COPY aggelies1 (id, perioxi, timi, typos_aggelias, emvadon, typos_akinitou, systhma_thermanshs, thlefwno, perigrafi, mpania, ypnodwmatia, email, photo, dieythinsi) FROM '$$PATH$$/1991.dat';

--
-- Name: aggelies1_id_seq; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('aggelies1_id_seq', 1, false);


--
-- Name: id_aggelies; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('id_aggelies', 4, true);


--
-- Name: id_aggelies1; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('id_aggelies1', 18, true);


--
-- Data for Name: images_aggelies; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY images_aggelies (id, email) FROM stdin;
\.
COPY images_aggelies (id, email) FROM '$$PATH$$/1994.dat';

--
-- Data for Name: messages; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY messages (name, surname, phone_number, email, text) FROM stdin;
\.
COPY messages (name, surname, phone_number, email, text) FROM '$$PATH$$/1981.dat';

--
-- Data for Name: messages1; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY messages1 (name, surname, phone_number, email, text, id, email2) FROM stdin;
\.
COPY messages1 (name, surname, phone_number, email, text, id, email2) FROM '$$PATH$$/1984.dat';

--
-- Name: messages1_id_seq; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('messages1_id_seq', 1, false);


--
-- Name: messages1_table; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('messages1_table', 1, false);


--
-- Data for Name: test; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY test (id, er, re) FROM stdin;
\.
COPY test (id, er, re) FROM '$$PATH$$/1987.dat';

--
-- Data for Name: test1; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY test1 (id, er, re) FROM stdin;
\.
COPY test1 (id, er, re) FROM '$$PATH$$/1989.dat';

--
-- Name: test1_id_seq; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('test1_id_seq', 1, false);


--
-- Name: test_id_seq; Type: SEQUENCE SET; Schema: it164760; Owner: it164760
--

SELECT pg_catalog.setval('test_id_seq', 1, false);


--
-- Data for Name: test_image; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY test_image (name, raster) FROM stdin;
\.
COPY test_image (name, raster) FROM '$$PATH$$/1982.dat';

--
-- Data for Name: user_pass; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY user_pass (nickname, password, email) FROM stdin;
\.
COPY user_pass (nickname, password, email) FROM '$$PATH$$/1979.dat';

--
-- Data for Name: users; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY users (name, surname, email, phone_number, status) FROM stdin;
\.
COPY users (name, surname, email, phone_number, status) FROM '$$PATH$$/1978.dat';

--
-- Data for Name: users1; Type: TABLE DATA; Schema: it164760; Owner: it164760
--

COPY users1 (onoma_epwnymo, email, kwdikos, status, picture) FROM stdin;
\.
COPY users1 (onoma_epwnymo, email, kwdikos, status, picture) FROM '$$PATH$$/1983.dat';

--
-- Data for Name: BLOBS; Type: BLOBS; Schema: -; Owner: 
--

SET search_path = pg_catalog;

\i $$PATH$$/2001.dat

SET search_path = it164760, pg_catalog;

--
-- Name: agapimena_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY agapimena
    ADD CONSTRAINT agapimena_pkey PRIMARY KEY (email, id);


--
-- Name: aggelies1_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY aggelies1
    ADD CONSTRAINT aggelies1_pkey PRIMARY KEY (id);


--
-- Name: images_aggelies_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY images_aggelies
    ADD CONSTRAINT images_aggelies_pkey PRIMARY KEY (id);


--
-- Name: messages1_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY messages1
    ADD CONSTRAINT messages1_pkey PRIMARY KEY (id);


--
-- Name: test1_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY test1
    ADD CONSTRAINT test1_pkey PRIMARY KEY (id);


--
-- Name: test_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY test
    ADD CONSTRAINT test_pkey PRIMARY KEY (id);


--
-- Name: user_pass_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY user_pass
    ADD CONSTRAINT user_pass_pkey PRIMARY KEY (nickname, email);


--
-- Name: users1_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY users1
    ADD CONSTRAINT users1_pkey PRIMARY KEY (email);


--
-- Name: users_pkey; Type: CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY users
    ADD CONSTRAINT users_pkey PRIMARY KEY (email);


--
-- Name: message_notification; Type: TRIGGER; Schema: it164760; Owner: it164760
--

CREATE TRIGGER message_notification AFTER INSERT ON messages FOR EACH ROW EXECUTE PROCEDURE change_status();


--
-- Name: status1; Type: TRIGGER; Schema: it164760; Owner: it164760
--

CREATE TRIGGER status1 AFTER INSERT ON messages1 FOR EACH ROW EXECUTE PROCEDURE change_users1_status();


--
-- Name: a_email; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY agapimena
    ADD CONSTRAINT a_email FOREIGN KEY (email) REFERENCES users1(email) ON DELETE CASCADE;


--
-- Name: a_id; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY agapimena
    ADD CONSTRAINT a_id FOREIGN KEY (id) REFERENCES aggelies1(id) ON DELETE CASCADE;


--
-- Name: i_id; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY images_aggelies
    ADD CONSTRAINT i_id FOREIGN KEY (id) REFERENCES aggelies1(id) ON DELETE CASCADE;


--
-- Name: m_email; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY messages
    ADD CONSTRAINT m_email FOREIGN KEY (email) REFERENCES users(email) ON DELETE CASCADE;


--
-- Name: m_email; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY messages1
    ADD CONSTRAINT m_email FOREIGN KEY (email) REFERENCES users1(email) ON DELETE CASCADE;


--
-- Name: users_email; Type: FK CONSTRAINT; Schema: it164760; Owner: it164760
--

ALTER TABLE ONLY user_pass
    ADD CONSTRAINT users_email FOREIGN KEY (email) REFERENCES users(email) ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--