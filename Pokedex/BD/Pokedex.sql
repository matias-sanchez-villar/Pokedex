create database Pokedex
go
use POKEDEX
go
CREATE TABLE Elementos(
	ID int primary key IDENTITY(1,1) NOT NULL,
	Descripcion varchar(50) NULL,
)
go
CREATE TABLE Pokemons(
	ID int primary key IDENTITY(1,1) NOT NULL,
	Numero int NULL,
	Nombre varchar(50) NULL,
	Descripcion varchar(50) NULL,
	UrlImagen varchar(300) NULL,
	IdTipo int NULL foreign key references Elementos(ID),
	IdDebilidad int NULL foreign key references Elementos(ID),
	IdEvolucion int NULL foreign key references Pokemons(ID),
)

-- inserta pokemons
insert into Pokemons values(1, 'Bulbasaur', 'Este Pokémon nace con una semilla en el lomo.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/001.png', null, null, null)
insert into Pokemons values(2, 'Ivysaur', 'Cuando le crece bastante el bulbo del lomo.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/002.png', null, null, null)
insert into Pokemons values(3, 'Venusaur', 'La planta florece cuando absorbe energía solar.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/003.png', null, null, null)

go
-- inserta elementos 
insert into Elementos values ('Planta')
insert into Elementos values ('Fuego')
insert into Elementos values ('Agua')

go
-- actualiza tipo y debilidad a los pokemons
update pokemons set IdTipo = 1
update pokemons set IdDebilidad = 2