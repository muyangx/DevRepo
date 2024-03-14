use master
go
--�������ݿ�
if DB_ID('GameDB') is not null
	drop database GameDB
go

create database GameDB on
(
	name='GameDB',
	filename='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameDB.mdf'
)
go
--ʹ�����ݿ�
use GameDB
go
--������
--�û���
create table Account
(
	AccountID	int primary key identity(1,1),
	AccountName nvarchar(20) not null unique ,
	AccountPwd nvarchar(20) not null,
	AccountSex int ,
	AccountEmail nvarchar(50),
)
go
create table Msg
(
	MsgID	int primary key identity(1,1),
	MsgTitle nvarchar(100) not null  ,
	MsgText text ,
	MsgType nvarchar(10) not null ,
	MsgPhoto nvarchar(100),
	MsgTime datetime not null,
	MsgHit int default(0),
	AccountID int  references Account(AccountID),
)
go
--�������
insert Account values('admin','123',1,null)
insert Account values('Lily','123',0,null)
insert Account values('С��','123',1,null)
go
insert Msg values('�崿��ŮCos�ݼ� �����츳����','��Ϊ���޾���;�����³裬�ݼ����ܹ��Ů����һ�ӭ�����գ��崿��Ů Moonka�� Cos ���ݼ���','���Ź���','/img/n00.jpg','2017-10-12',12,1)
insert Msg values('�ݼ�','�ݼ�','Ӣ�۵���','/img/�ݼ�.jpg','2017-8-1',31,1)
insert Msg values('����','����','Ӣ�۵���','/img/����.jpg','2017-8-1',13,1)
insert Msg values('С��','С��','Ӣ�۵���','/img/С��.jpg','2017-8-1',34,1)
insert Msg values('������','������','Ӣ�۵���','/img/������.jpg','2017-8-1',23,1)
insert Msg values('槼�','槼�','Ӣ�۵���','/img/槼�.jpg','2017-8-1',45,1)

insert Msg values('��Ϸ��ͼ�����־���','��Ϸ��ͼ�����־���','��ƵͼƬ','/img/n02.jpg',getdate(),16,1)
insert Msg values('��Ϸ��ͼ�����Ʒ���','��Ϸ��ͼ�����Ʒ���','��ƵͼƬ','/img/n03.jpg',getdate(),56,1)
insert Msg values('��Ϸ��Ƶ����Ӣ�ۡ�','��Ϸ��Ƶ����Ӣ�ۡ�','��ƵͼƬ','/img/video3.png',getdate(),16,1)

insert Msg values('�޾���;�ֳ��µ�ͼ��','�޾���;�ֳ��µ�ͼ������ϼεѤ���ޱȡ�','���Ź���','/img/n01.jpg',getdate(),0,2)
go

select *from Account
select *from Msg
