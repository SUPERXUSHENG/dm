create database Library 
go
use Library

--����Ա��
create table Manager
(
	managerid char(20) primary key,--�˺�
	managerPassword char(12) not null,--����
	mIdentity bit not null default 1,--���(����Ա-1��������Ա-0)
)

--ͼ������
create table BookCategory
(
	bCategoryid int primary key,--ͼ�������
	bCategoryname nchar(16) not null,--ͼ���������
)

--ͼ����Ϣ��
create table BookList
(
	ISBN char(25) primary key,--ISBN
	BookName nchar(30) not null, --����
	bCategoryid int not null foreign key references BookCategory,--ͼ�������
	author nchar(20) not null, --��һ����
	publisher nchar(30) not null,--��һ������
	publishTime int not null, --�������
	bookstate bit not null default 1, --״̬������-1������-0��
	num int not null, --�����Ŀ
	lendnum int not null, --�����Ŀ 
	price float not null --����
)

--�������
create table ReaderCategory
(
	Rcategoryid int not null primary key, --��������� 
	Rcategoryname nchar(10) not null, --����������� 
	Rbnum int not null, --�ɽ�����Ŀ
	Rday int not null --�ɽ�������
)

--������Ϣ��
create table Reader
(
	Rid char(19) primary key, --���֤��
	Rname nchar(10) not null, --����
	Rcategoryid int not null foreign key references ReaderCategory, --���ѧ������ʦ�ȣ�
	Phone char(11), --�绰
	RbLnum int not null, --�ѽ�����Ŀ
)

--�����¼��ϸ
create table BookLendList
(
	Rid char(19) not null foreign key references Reader, --�������֤��
	ISBN char(25) not null foreign key references BookList,--ISBN
	LendTime datetime not null Default getdate(), --����ʱ��
	BackTime datetime not null Default getdate(), --����ʱ��
	money float not null, --���ڿۿ�
	isback bit not null, --�Ƿ��ѻ��� 
	renew bit not null--�Ƿ�����
)

