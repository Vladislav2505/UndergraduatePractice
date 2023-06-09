PGDMP         9                {            topchiev    15.2    15.2 ?    R           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            S           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            T           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            U           1262    17218    topchiev    DATABASE     |   CREATE DATABASE topchiev WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE topchiev;
                postgres    false            �            1259    17286    company    TABLE     �   CREATE TABLE public.company (
    cmp_id integer NOT NULL,
    name character varying(100) NOT NULL,
    short_name character varying(50) NOT NULL,
    address character varying(150)
);
    DROP TABLE public.company;
       public         heap    postgres    false            �            1259    17285    company_cmp_id_seq    SEQUENCE     �   CREATE SEQUENCE public.company_cmp_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.company_cmp_id_seq;
       public          postgres    false    225            V           0    0    company_cmp_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.company_cmp_id_seq OWNED BY public.company.cmp_id;
          public          postgres    false    224            �            1259    17233    faculty    TABLE     �   CREATE TABLE public.faculty (
    fac_id integer NOT NULL,
    name character varying(100) NOT NULL,
    short_name character varying(50) NOT NULL,
    un_code integer NOT NULL
);
    DROP TABLE public.faculty;
       public         heap    postgres    false            �            1259    17292 
   internship    TABLE     �  CREATE TABLE public.internship (
    rec_book_id character varying(50) NOT NULL,
    sup_id integer NOT NULL,
    cmp_id integer NOT NULL,
    first_name character varying(50) NOT NULL,
    surname character varying(50),
    last_name character varying(50) NOT NULL,
    post character varying(50) NOT NULL,
    start_date date,
    end_date date,
    grade character varying(50),
    enterprise_work character varying(200)
);
    DROP TABLE public.internship;
       public         heap    postgres    false            �            1259    17243 
   speciality    TABLE     �   CREATE TABLE public.speciality (
    spec_id character varying(20) NOT NULL,
    name character varying(100) NOT NULL,
    short_name character varying(50) NOT NULL,
    fac_id integer NOT NULL
);
    DROP TABLE public.speciality;
       public         heap    postgres    false            �            1259    17268    student    TABLE     �   CREATE TABLE public.student (
    rec_book_id character varying(50) NOT NULL,
    first_name character varying(50) NOT NULL,
    surname character varying(50),
    last_name character varying(50) NOT NULL,
    gp_id character varying(50) NOT NULL
);
    DROP TABLE public.student;
       public         heap    postgres    false            �            1259    17227 
   study_type    TABLE     �   CREATE TABLE public.study_type (
    st_id integer NOT NULL,
    name character varying(100) NOT NULL,
    short_name character varying(50) NOT NULL
);
    DROP TABLE public.study_type;
       public         heap    postgres    false            �            1259    17226    study_type_st_id_seq    SEQUENCE     �   CREATE SEQUENCE public.study_type_st_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.study_type_st_id_seq;
       public          postgres    false    217            W           0    0    study_type_st_id_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.study_type_st_id_seq OWNED BY public.study_type.st_id;
          public          postgres    false    216            �            1259    17279 
   supervisor    TABLE     �   CREATE TABLE public.supervisor (
    sup_id integer NOT NULL,
    first_name character varying(50) NOT NULL,
    surname character varying(50),
    last_name character varying(50) NOT NULL,
    post character varying(50) NOT NULL
);
    DROP TABLE public.supervisor;
       public         heap    postgres    false            �            1259    17278    supervisor_sup_id_seq    SEQUENCE     �   CREATE SEQUENCE public.supervisor_sup_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 ,   DROP SEQUENCE public.supervisor_sup_id_seq;
       public          postgres    false    223            X           0    0    supervisor_sup_id_seq    SEQUENCE OWNED BY     O   ALTER SEQUENCE public.supervisor_sup_id_seq OWNED BY public.supervisor.sup_id;
          public          postgres    false    222            �            1259    17253    un_group    TABLE     �   CREATE TABLE public.un_group (
    gp_id character varying(50) NOT NULL,
    stream character varying(50) NOT NULL,
    term_protection date NOT NULL,
    st_id integer NOT NULL,
    spec_id character varying(20) NOT NULL
);
    DROP TABLE public.un_group;
       public         heap    postgres    false            �            1259    17314    test    VIEW     "  CREATE VIEW public.test AS
 SELECT concat(student.rec_book_id, ': ', student.last_name, ' ', student.first_name) AS "Студент",
    speciality.name AS "Специальность",
    un_group.stream AS "Поток",
    company.short_name AS "Предприятие",
    company.address AS "Адрес",
    internship.start_date AS "Начало",
    internship.end_date AS "Конец",
    internship.grade AS "Оценка"
   FROM ((((public.internship
     JOIN public.student ON (((internship.rec_book_id)::text = (student.rec_book_id)::text)))
     JOIN public.company ON ((internship.cmp_id = company.cmp_id)))
     JOIN public.un_group ON (((student.gp_id)::text = (un_group.gp_id)::text)))
     JOIN public.speciality ON (((un_group.spec_id)::text = (speciality.spec_id)::text)));
    DROP VIEW public.test;
       public          postgres    false    226    226    226    226    226    225    225    225    221    221    221    221    220    220    220    219    219            �            1259    17220 
   university    TABLE     �   CREATE TABLE public.university (
    un_code integer NOT NULL,
    name character varying(100) NOT NULL,
    short_name character varying(50) NOT NULL
);
    DROP TABLE public.university;
       public         heap    postgres    false            �            1259    17219    university_un_code_seq    SEQUENCE     �   CREATE SEQUENCE public.university_un_code_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.university_un_code_seq;
       public          postgres    false    215            Y           0    0    university_un_code_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.university_un_code_seq OWNED BY public.university.un_code;
          public          postgres    false    214            �            1259    17320    users    TABLE     �   CREATE TABLE public.users (
    id integer NOT NULL,
    login character varying(200) NOT NULL,
    password character varying(100) NOT NULL
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    17319    users_id_seq    SEQUENCE     �   CREATE SEQUENCE public.users_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 #   DROP SEQUENCE public.users_id_seq;
       public          postgres    false    229            Z           0    0    users_id_seq    SEQUENCE OWNED BY     =   ALTER SEQUENCE public.users_id_seq OWNED BY public.users.id;
          public          postgres    false    228            �           2604    17289    company cmp_id    DEFAULT     p   ALTER TABLE ONLY public.company ALTER COLUMN cmp_id SET DEFAULT nextval('public.company_cmp_id_seq'::regclass);
 =   ALTER TABLE public.company ALTER COLUMN cmp_id DROP DEFAULT;
       public          postgres    false    224    225    225            �           2604    17230    study_type st_id    DEFAULT     t   ALTER TABLE ONLY public.study_type ALTER COLUMN st_id SET DEFAULT nextval('public.study_type_st_id_seq'::regclass);
 ?   ALTER TABLE public.study_type ALTER COLUMN st_id DROP DEFAULT;
       public          postgres    false    217    216    217            �           2604    17282    supervisor sup_id    DEFAULT     v   ALTER TABLE ONLY public.supervisor ALTER COLUMN sup_id SET DEFAULT nextval('public.supervisor_sup_id_seq'::regclass);
 @   ALTER TABLE public.supervisor ALTER COLUMN sup_id DROP DEFAULT;
       public          postgres    false    222    223    223            �           2604    17223    university un_code    DEFAULT     x   ALTER TABLE ONLY public.university ALTER COLUMN un_code SET DEFAULT nextval('public.university_un_code_seq'::regclass);
 A   ALTER TABLE public.university ALTER COLUMN un_code DROP DEFAULT;
       public          postgres    false    215    214    215            �           2604    17323    users id    DEFAULT     d   ALTER TABLE ONLY public.users ALTER COLUMN id SET DEFAULT nextval('public.users_id_seq'::regclass);
 7   ALTER TABLE public.users ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    228    229    229            L          0    17286    company 
   TABLE DATA           D   COPY public.company (cmp_id, name, short_name, address) FROM stdin;
    public          postgres    false    225   �K       E          0    17233    faculty 
   TABLE DATA           D   COPY public.faculty (fac_id, name, short_name, un_code) FROM stdin;
    public          postgres    false    218   M       M          0    17292 
   internship 
   TABLE DATA           �   COPY public.internship (rec_book_id, sup_id, cmp_id, first_name, surname, last_name, post, start_date, end_date, grade, enterprise_work) FROM stdin;
    public          postgres    false    226   +N       F          0    17243 
   speciality 
   TABLE DATA           G   COPY public.speciality (spec_id, name, short_name, fac_id) FROM stdin;
    public          postgres    false    219   �O       H          0    17268    student 
   TABLE DATA           U   COPY public.student (rec_book_id, first_name, surname, last_name, gp_id) FROM stdin;
    public          postgres    false    221   �P       D          0    17227 
   study_type 
   TABLE DATA           =   COPY public.study_type (st_id, name, short_name) FROM stdin;
    public          postgres    false    217   �Q       J          0    17279 
   supervisor 
   TABLE DATA           R   COPY public.supervisor (sup_id, first_name, surname, last_name, post) FROM stdin;
    public          postgres    false    223   �Q       G          0    17253    un_group 
   TABLE DATA           R   COPY public.un_group (gp_id, stream, term_protection, st_id, spec_id) FROM stdin;
    public          postgres    false    220   S       B          0    17220 
   university 
   TABLE DATA           ?   COPY public.university (un_code, name, short_name) FROM stdin;
    public          postgres    false    215   �S       O          0    17320    users 
   TABLE DATA           4   COPY public.users (id, login, password) FROM stdin;
    public          postgres    false    229   �T       [           0    0    company_cmp_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.company_cmp_id_seq', 10, true);
          public          postgres    false    224            \           0    0    study_type_st_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.study_type_st_id_seq', 6, true);
          public          postgres    false    216            ]           0    0    supervisor_sup_id_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.supervisor_sup_id_seq', 10, true);
          public          postgres    false    222            ^           0    0    university_un_code_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.university_un_code_seq', 10, true);
          public          postgres    false    214            _           0    0    users_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.users_id_seq', 1, false);
          public          postgres    false    228            �           2606    17291    company company_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.company
    ADD CONSTRAINT company_pkey PRIMARY KEY (cmp_id);
 >   ALTER TABLE ONLY public.company DROP CONSTRAINT company_pkey;
       public            postgres    false    225            �           2606    17237    faculty faculty_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.faculty
    ADD CONSTRAINT faculty_pkey PRIMARY KEY (fac_id);
 >   ALTER TABLE ONLY public.faculty DROP CONSTRAINT faculty_pkey;
       public            postgres    false    218            �           2606    17298    internship internship_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.internship
    ADD CONSTRAINT internship_pkey PRIMARY KEY (rec_book_id);
 D   ALTER TABLE ONLY public.internship DROP CONSTRAINT internship_pkey;
       public            postgres    false    226            �           2606    17247    speciality speciality_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.speciality
    ADD CONSTRAINT speciality_pkey PRIMARY KEY (spec_id);
 D   ALTER TABLE ONLY public.speciality DROP CONSTRAINT speciality_pkey;
       public            postgres    false    219            �           2606    17272    student student_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.student
    ADD CONSTRAINT student_pkey PRIMARY KEY (rec_book_id);
 >   ALTER TABLE ONLY public.student DROP CONSTRAINT student_pkey;
       public            postgres    false    221            �           2606    17232    study_type study_type_pkey 
   CONSTRAINT     [   ALTER TABLE ONLY public.study_type
    ADD CONSTRAINT study_type_pkey PRIMARY KEY (st_id);
 D   ALTER TABLE ONLY public.study_type DROP CONSTRAINT study_type_pkey;
       public            postgres    false    217            �           2606    17284    supervisor supervisor_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.supervisor
    ADD CONSTRAINT supervisor_pkey PRIMARY KEY (sup_id);
 D   ALTER TABLE ONLY public.supervisor DROP CONSTRAINT supervisor_pkey;
       public            postgres    false    223            �           2606    17257    un_group un_group_pkey 
   CONSTRAINT     W   ALTER TABLE ONLY public.un_group
    ADD CONSTRAINT un_group_pkey PRIMARY KEY (gp_id);
 @   ALTER TABLE ONLY public.un_group DROP CONSTRAINT un_group_pkey;
       public            postgres    false    220            �           2606    17225    university university_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.university
    ADD CONSTRAINT university_pkey PRIMARY KEY (un_code);
 D   ALTER TABLE ONLY public.university DROP CONSTRAINT university_pkey;
       public            postgres    false    215            �           2606    17325    users users_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.users DROP CONSTRAINT users_pkey;
       public            postgres    false    229            �           2606    17238    faculty fac_fk1    FK CONSTRAINT     x   ALTER TABLE ONLY public.faculty
    ADD CONSTRAINT fac_fk1 FOREIGN KEY (un_code) REFERENCES public.university(un_code);
 9   ALTER TABLE ONLY public.faculty DROP CONSTRAINT fac_fk1;
       public          postgres    false    3223    215    218            �           2606    17258    un_group gp_fk1    FK CONSTRAINT     t   ALTER TABLE ONLY public.un_group
    ADD CONSTRAINT gp_fk1 FOREIGN KEY (st_id) REFERENCES public.study_type(st_id);
 9   ALTER TABLE ONLY public.un_group DROP CONSTRAINT gp_fk1;
       public          postgres    false    220    217    3225            �           2606    17263    un_group gp_fk2    FK CONSTRAINT     x   ALTER TABLE ONLY public.un_group
    ADD CONSTRAINT gp_fk2 FOREIGN KEY (spec_id) REFERENCES public.speciality(spec_id);
 9   ALTER TABLE ONLY public.un_group DROP CONSTRAINT gp_fk2;
       public          postgres    false    219    3229    220            �           2606    17299    internship inter_fk1    FK CONSTRAINT     �   ALTER TABLE ONLY public.internship
    ADD CONSTRAINT inter_fk1 FOREIGN KEY (rec_book_id) REFERENCES public.student(rec_book_id);
 >   ALTER TABLE ONLY public.internship DROP CONSTRAINT inter_fk1;
       public          postgres    false    3233    226    221            �           2606    17304    internship inter_fk2    FK CONSTRAINT     {   ALTER TABLE ONLY public.internship
    ADD CONSTRAINT inter_fk2 FOREIGN KEY (sup_id) REFERENCES public.supervisor(sup_id);
 >   ALTER TABLE ONLY public.internship DROP CONSTRAINT inter_fk2;
       public          postgres    false    223    3235    226            �           2606    17309    internship inter_fk3    FK CONSTRAINT     x   ALTER TABLE ONLY public.internship
    ADD CONSTRAINT inter_fk3 FOREIGN KEY (cmp_id) REFERENCES public.company(cmp_id);
 >   ALTER TABLE ONLY public.internship DROP CONSTRAINT inter_fk3;
       public          postgres    false    3237    225    226            �           2606    17248    speciality spec_fk1    FK CONSTRAINT     w   ALTER TABLE ONLY public.speciality
    ADD CONSTRAINT spec_fk1 FOREIGN KEY (fac_id) REFERENCES public.faculty(fac_id);
 =   ALTER TABLE ONLY public.speciality DROP CONSTRAINT spec_fk1;
       public          postgres    false    218    219    3227            �           2606    17273    student st_fk1    FK CONSTRAINT     q   ALTER TABLE ONLY public.student
    ADD CONSTRAINT st_fk1 FOREIGN KEY (gp_id) REFERENCES public.un_group(gp_id);
 8   ALTER TABLE ONLY public.student DROP CONSTRAINT st_fk1;
       public          postgres    false    221    3231    220            L   b  x��R�N�@=�~�~ "ET�?�@�$��\LP��7/������/x�G����o�4���μyof�)�1q�w���=�G����"��a�C:,�?׀������fe��+wJ�q"�=W�ף�.?@�tx��m��|�s��3DX���ՊK:�cMQ��-�#?�f۪��SU�Y�}Rp�=(�������F���	k��Ĕ���Q���l�`��(�g�P�;iV�����a��T�3��XFP�����&�NTR����O�������i�J�H��_�^|�S�Q�|e?Yt�is��(��F��4Fʹ�C-P_�N�8hw��?ٷ�C�[���vq�}Zn�.���/��C�      E     x�5�[N�0E��Ud��v�t/,�qU@*��G�
�D%���q�pgG�q@�-��y�f�3��=N�!�k�NV��3�u�(k��
�������qT��fn���oH�<�8�jbR|�'#,Rn�nL��8��qv>�����I�<H,đ����hWھ���"����eX��-~sX�PR��zd2��
���Q,��MU��Z��_l1؅o�rfp�B���'R[]�7�Ό+Ϗn��쨶���_ś��      M   F  x�u�[N�0E��UtA�������~P!��O�$mS�pgG�!i�CȎ<�s�\����M���+�%���+6�c�-
,n�c#CM�1��+TI�Y��%*㭏B�9�0�01����5r��b#g���yq�dU/\֪�K@)c�{"V��o
������Ӗ�8�Pw*b�<������ܰO���d�X�ʨ��s!#���ۆ�3n�.�vЋ����ʄ�
�~K�.��q$��mk�����I}�8�nz%���&1L=Qގ-����!�’jO�hݠyZ��}�gNI��*�;b� �}5�ǳ��A�	�X7�      F     x�UPKN�0\ۧ���!�]8L�RX��mQ\ *�ͧW߈yV+���|ߘ"5.5V�A�#̡
uX���CxJ0$a�^����w{AZ�|�"�lCp�����6T	u���yoJ��uL�^0`	�b��	�b�씵�s^���������X@z�2��^�b":3�=q���(���@�Ezq��Se��y�%%�����&k�,"����uav-�Wr?w�/�|/��AT���ܴ����/l�+.K�;��g�qů��0{�Wڕ�7���!��      H   �   x�m�[jAE��W�H?f|��Ōh�!&D\A3*��[�����q$4����T��+�+��"�FfyW���g�dŹ�����wY��+��T2ǝ#�y�����wR����$�=��,��W�.}R��t1���-ˮ�:k����}�IU���I���dD�/3Lh�I)L=���R�V�S���MƣaY���/����yV|���N��?C��      D   S   x�3�0�b���6\�2��8/L����>���e�ya!����> �x���dm�{/츰"����<S�i^� ��gB      J     x��Q[N�0��O� ʛ�p7�@*<��$��#9N�\a�F�.�����wvvf�;sxG�Qj�%:y@b0�Y�>г��9
٭�+{��$�#�r�>�$EwO�he.�rcnl8�LadAG2�5�c�GS+t��'	b�р���'T��<qx&���k ͗)�UZq��`�[]LĚ��~��oRbEè�tޟ�B��:�8�0X�S'h��v#�ׅiF�h+������g{:��^Os1�i.'<��p��\x� ��1�      G   m   x�e��� ���. �DwqGp7p��j0ѐ��IOo�^׺���!QO�K�r $�|����Ƈ�)bcѳ���L��4��m�KK��6[ۍ��t	ι�VA�      B   �   x�őKn�@DמSp">I��p�VE	b6��9N�&�+T߈�"H @��<jw�7r���T���s|c.�X��n<F
�D?�����P��M)@W-����2��k�������'M9G�%�1��`�!%�올�/��Y�(�����<�Aj+��������cNZ*j�'�14O�>��z��==K֓z6��+�iq�.�(�k�/��r������v�����w\0Ƭl���      O      x������ � �     