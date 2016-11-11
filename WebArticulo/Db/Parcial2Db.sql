create table Ventas(
VentaId int primary key,
Fecha date,
Monto float
);

create table Articulos(
ArticuloId int primary key,
Descripcion varchar(150),
Existencia int,
Precio float
);

create table VentasDetalle(
Id int primary key,
IdVentaId int,
IdArticuloId int,
Cantidad int,
Precio float
);