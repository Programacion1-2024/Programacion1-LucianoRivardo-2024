﻿namespace La_deliciosa_lasagna_de_Luciano { }

    /*
        Consigna: 
            ¡La novia de Lucian está de camino a casa y él no ha preparado la cena de aniversario!

            En este ejercicio, escribirás código para ayudar a Lucian a cocinar una exquisita lasaña de
    su libro de cocina favorito.

            Tienes cuatro tareas, todas ellas relacionadas con el tiempo empleado en cocinar la lasaña.

            Tarea 1: Definir el tiempo esperado del horno en minutos.
                Define el método Lasagna.ExpectedMinutesInOven() que no toma ningún parámetro y 
    devuelve cuántos minutos debe estar la lasaña en el horno. 
    Según el libro de cocina, el tiempo esperado de horno en minutos es de 40.

            Tarea 2: Calcular el tiempo restante del horno en minutos.
                Defina el método Lasagna.RemainingMinutesInOven() que toma como parámetro los minutos 
    reales que la lasaña ha estado en el horno y devuelve cuántos minutos aún le quedan a la lasaña en el horno,
    según el tiempo de horno esperado en minutos de la tarea anterior.
    
            Tarea 3: Calcular el tiempo de preparación en minutos.
                Defina el método Lasagna.PreparationTimeInMinutes() que toma la 
    cantidad de capas que agregó a la lasaña como parámetro y devuelve 
    cuántos minutos pasó preparando la lasaña, asumiendo que cada capa le toma 2 minutos para prepararse.
     */

    public class Lasagna
    {
    // TODO: definir el método 'ExpectedMinutesInOven()'
        public int ExpectedMinutesInOven()
        {
            return 40;
        }


    // TODO: definir el método  'RemainingMinutesInOven()'
        public int RemainingMinutesInOven(int minutos)
        {
            return ExpectedMinutesInOven() - minutos;
        }

    // TODO: definir el método  'PreparationTimeInMinutes()'
        public int PreparationTimeInMinutes(int capas)
        {
            return capas * 2;
        }

    // TODO: definir el método  'ElapsedTimeInMinutes()'
        public int ElapsedTimeInMinutes(int capas, int tiempo)
        {
            return PreparationTimeInMinutes(capas) + tiempo;
        }
    }

