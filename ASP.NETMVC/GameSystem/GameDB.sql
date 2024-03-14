use master
go
--创建数据库
if DB_ID('GameDB') is not null
	drop database GameDB
go

create database GameDB on
(
	name='GameDB',
	filename='C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\GameDB.mdf'
)
go
--使用数据库
use GameDB
go
--创建表
--用户表
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
--添加数据
insert Account values('admin','123',1,null)
insert Account values('Lily','123',0,null)
insert Account values('小白','123',1,null)
go
insert Msg values('清纯美女Cos虞姬 种族天赋爆棚','作为《无尽征途》的新宠，虞姬最受广大女性玩家欢迎，近日，清纯美女 Moonka就 Cos 了虞姬。','新闻公告','/img/n00.jpg','2017-10-12',12,1)
insert Msg values('虞姬','虞姬','英雄档案','/img/虞姬.jpg','2017-8-1',31,1)
insert Msg values('吕布','吕布','英雄档案','/img/吕布.jpg','2017-8-1',13,1)
insert Msg values('小乔','小乔','英雄档案','/img/小乔.jpg','2017-8-1',34,1)
insert Msg values('赵子龙','赵子龙','英雄档案','/img/赵子龙.jpg','2017-8-1',23,1)
insert Msg values('妲己','妲己','英雄档案','/img/妲己.jpg','2017-8-1',45,1)

insert Msg values('游戏截图：《街景》','游戏截图：《街景》','视频图片','/img/n02.jpg',getdate(),16,1)
insert Msg values('游戏截图：《牌坊》','游戏截图：《牌坊》','视频图片','/img/n03.jpg',getdate(),56,1)
insert Msg values('游戏视频：《英雄》','游戏视频：《英雄》','视频图片','/img/video3.png',getdate(),16,1)

insert Msg values('无尽征途又出新地图！','无尽征途又出新地图，云蒸霞蔚绚烂无比。','新闻公告','/img/n01.jpg',getdate(),0,2)
go

select *from Account
select *from Msg
