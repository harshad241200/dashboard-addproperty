create table Addproperty1(
id int identity primary key,
pname varchar(200),
minprice varchar (200),
maxprice varchar (200),
uploadfile varchar (200),
facebookurl varchar (200),
instagramurl varchar (200),
whatsapp int,
youtubeviewurl varchar (200),
areainsqft int,
noofbedroom int,
noofbathroom int,
garage int,
listpropertyfor int,
ihavea int,
propertytype int,
availablefor int,
googlemapurl varchar(200),
shortdiscription varchar (200),
longdescription varchar (200),
nearbyplaces varchar (200),
landmark varchar (200),
city varchar (200),
pincode int,
fulladdress varchar (200),
);

insert into Addproperty1(pname,minprice,maxprice,uploadfile,facebookurl,instagramurl,whatsapp,youtubeviewurl,areainsqft,noofbedroom,noofbathroom,garage,ihavea,propertytype,availablefor,googlemapurl,shortdiscription,longdescription,nearbyplaces,landmark,city,pincode,fulladdress)values('vinayak',2500,3000,'khkhhkh','facebookk','instgrm',985445555,'ytube',450,2,22,5,55,45,22,'thane','gfff','gmjgj','mumbai','kurla','dombivli',40021,'subhashnagar');
drop table Addproperty1;
select * from  Addproperty1;
