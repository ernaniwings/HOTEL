create table appUser(

	idUser int primary key identity(1,1),
	name char(25) not null,
	email char(25) not null,
	password char(25) not null,
	card char(20) not null

)
create table hotel(

	idHotel int primary key identity(1,1),
	name char(25) not null,
	descri char(25) not null,
	idAppUser foreign key references appUser(idUser)

)
create table room(

	idRoom int primary key identity(1,1),
	type int not null,
	idHotel foreign key references hotel(idHotel)

)
create table client(

	idClient int primary key identity(1,1),
	name char(30) not null,
	cpf char(15) not null,
	phone char(20),
	email char(35)


)