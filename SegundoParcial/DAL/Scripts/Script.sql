create database SegundoParcialDb
go
use SegundoParcialDb
go

create table Vehiculos
(
    VehiculosId int primary key identity(1,1),
	Descripcion varchar(40),
	Mantenimiento money
);
go
create table Talleres
(
    TallerId int primary key identity(1,1),
	Nombre varchar(30),
);
go

create table RegistroArticulo
(
		ArticulosId int primary key identity(1,1),
		Descripcion varchar(30),
        costo money,
        Ganancia money,
        precio money,
        Inventario int
);

create table RegistroMantenimientos
(
			MantenimientoId int primary key identity(1,1),
			VehiculoId int,
            Fecha date,
			Subtotal money,
			itbis money,
			Total money
);

go
create table RegistroMantenimientoDetalle
(
			Id int primary key identity(1,1),
			MantenimientoId int,
            TallerId int,
            ArticulosId int,
            Articulo varchar(40),
            Cantidad int,
            Precio int,
            Importe int
);

go
create table RegistroEntradaArticulos
(
			EntradaId int primary key identity(1,1),
            Fecha date,
            Articulos Varchar(40),          
            Cantidad int
);