PGDMP     6    (            
    |            UTS    12.18    12.18                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    53505    UTS    DATABASE     �   CREATE DATABASE "UTS" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'English_Indonesia.1252' LC_CTYPE = 'English_Indonesia.1252';
    DROP DATABASE "UTS";
                postgres    false            �            1259    53514    admin    TABLE     �   CREATE TABLE public.admin (
    id_admin integer NOT NULL,
    username character varying(8) NOT NULL,
    pass character varying(8) NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false            �            1259    53512    admin_id_admin_seq    SEQUENCE     �   CREATE SEQUENCE public.admin_id_admin_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.admin_id_admin_seq;
       public          postgres    false    205                       0    0    admin_id_admin_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.admin_id_admin_seq OWNED BY public.admin.id_admin;
          public          postgres    false    204            �            1259    53508    person    TABLE     �   CREATE TABLE public.person (
    person_id integer NOT NULL,
    nama character varying(64) NOT NULL,
    username character varying(8) NOT NULL,
    pass character varying(8) NOT NULL
);
    DROP TABLE public.person;
       public         heap    postgres    false            �            1259    53506    person_person_id_seq    SEQUENCE     �   CREATE SEQUENCE public.person_person_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.person_person_id_seq;
       public          postgres    false    203                       0    0    person_person_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.person_person_id_seq OWNED BY public.person.person_id;
          public          postgres    false    202            �            1259    53540    task    TABLE     �   CREATE TABLE public.task (
    id_tugas integer NOT NULL,
    tanggal_tugas date NOT NULL,
    deadline date NOT NULL,
    nama_tugas character varying(100) NOT NULL
);
    DROP TABLE public.task;
       public         heap    postgres    false            �            1259    53538    task_id_tugas_seq    SEQUENCE     �   CREATE SEQUENCE public.task_id_tugas_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.task_id_tugas_seq;
       public          postgres    false    207                       0    0    task_id_tugas_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.task_id_tugas_seq OWNED BY public.task.id_tugas;
          public          postgres    false    206            �
           2604    53517    admin id_admin    DEFAULT     p   ALTER TABLE ONLY public.admin ALTER COLUMN id_admin SET DEFAULT nextval('public.admin_id_admin_seq'::regclass);
 =   ALTER TABLE public.admin ALTER COLUMN id_admin DROP DEFAULT;
       public          postgres    false    205    204    205            �
           2604    53511    person person_id    DEFAULT     t   ALTER TABLE ONLY public.person ALTER COLUMN person_id SET DEFAULT nextval('public.person_person_id_seq'::regclass);
 ?   ALTER TABLE public.person ALTER COLUMN person_id DROP DEFAULT;
       public          postgres    false    202    203    203            �
           2604    53543    task id_tugas    DEFAULT     n   ALTER TABLE ONLY public.task ALTER COLUMN id_tugas SET DEFAULT nextval('public.task_id_tugas_seq'::regclass);
 <   ALTER TABLE public.task ALTER COLUMN id_tugas DROP DEFAULT;
       public          postgres    false    206    207    207                      0    53514    admin 
   TABLE DATA           9   COPY public.admin (id_admin, username, pass) FROM stdin;
    public          postgres    false    205   l                 0    53508    person 
   TABLE DATA           A   COPY public.person (person_id, nama, username, pass) FROM stdin;
    public          postgres    false    203   �                 0    53540    task 
   TABLE DATA           M   COPY public.task (id_tugas, tanggal_tugas, deadline, nama_tugas) FROM stdin;
    public          postgres    false    207   �                  0    0    admin_id_admin_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.admin_id_admin_seq', 1, true);
          public          postgres    false    204                       0    0    person_person_id_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.person_person_id_seq', 1, false);
          public          postgres    false    202                       0    0    task_id_tugas_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.task_id_tugas_seq', 1, true);
          public          postgres    false    206                  x�3�LL��̃�\1z\\\ 8Z            x������ � �         &   x�3�4202�5��52�3�8sS�KK�b���� �.)     