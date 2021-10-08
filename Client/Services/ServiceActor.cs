using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Client.Services
{
    public class ServiceActor:IServiceActor
    {
        public List<Actor> GetActors()
        {
            return new List<Actor>(){
                new Actor() {Name="Mario Casas", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor1.jpg", Biography="Nacido el 12 de junio de 1986, en La Coruña, Galicia (España), decide dedicarse convertirse en actor tras haber participado en varios anuncios publicitarios. Empieza sus estudios de interpretación en la Escuela Cristina Rota."},
                new Actor() {Name="Will Smith", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor2.jpg", Biography="Will Smith estaba destinado a desarrollar su carrera en la música cuando, en 1989, conoció a Benny Medina, productor ejecutivo de Warner, quién le dio el papel principal en la serie de televisión 'El Príncipe de Bel-Air'. "},
                new Actor() {Name="Jason Statham", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor3.jpg", Biography="Deportista olímpico del equipo británico, y a su vez, modelo y vendedor de joyería, Jason Statham fue descubierto paseando en Londres por el director Guy Ritchie, que le contrató para su primera película, 'Lock & Stock' en 1998 ."},
                new Actor() {Name="Dwayne Johnson", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor4.jpg", Biography="Dwayne Johnson crece en el seno de una familia de luchadores profesionales y, desde muy niño, su vida parece destinada a desarrollarse en el mundo del deporte. Aunque comienza su carrera deportiva practicando fútbol americano, una lesión le lleva a abandonarlo y a desarrollar su afición por la lucha libre de forma profesional."},
                new Actor() {Name="Zac Efron", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor5.jpg", Biography="Zack Efron comienza a recibir clases de canto a la edad de 11 años y realiza sus primeros pinitos como actor en sobre las tablas de un escenario en una fábula musical."},
                new Actor() {Name="Margot Robbie", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor6.jpg", Biography="Zack Efron comienza a recibir clases de canto a la edad de 11 años y realiza sus primeros pinitos como actor en sobre las tablas de un escenario en una fábula musical."},
                new Actor() {Name="Jelena Noura Hadid", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor7.jpg", Biography="Es una de las top del momento pero la conocemos más como Gigi Hadid. Fue ella misma la que explicó de donde le viene su mote. Mi abuela llamaba así a mi madre cuando era joven, pero sólo dentro de la casa. A mí también me llamaban así."},
                new Actor() {Name="Emily Scott", BirthDate = new DateTime(2021,09,24), Photo="/Images/actors/actor8.jfif", Biography="En el documento de identidad de Emma Stone aparece su verdadero nombre, Emily Scott, que se tuvo que cambiar porque ya había una DJ y presentadora australiana que se llamaba igual. Decidió llamarse primero Riley Stone, y le duró seis meses"},
            };
        }
    }
}