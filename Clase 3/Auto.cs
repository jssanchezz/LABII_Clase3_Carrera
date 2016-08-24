﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    public class Auto
    {
        private eFabricante Fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TT;
        private int kilometrosRecorridos;
        
        public static int contadorDeObjetos;
        private static Random randomMarcas;
        
        public Auto() //Constructor de instancia
        {
            //Random rand = new Random();
            //int num = rand.Next(0, 4);
            this.Fabricante = (eFabricante) randomMarcas.Next(0,3);
            this.DI = new Rueda();
            this.DD = new Rueda();
            this.TI = new Rueda();
            this.TT = new Rueda();
            Auto.contadorDeObjetos++;
        }

        public static bool CompararAuto(Auto primero, Auto segundo)
        {
            if (primero.Fabricante == segundo.Fabricante)
                return true;
            return false;
        }

        static Auto() //Constructor estàtico
        {
            Auto.contadorDeObjetos = 0;
            Auto.randomMarcas = new Random();
        }

        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + this.Fabricante);
            Console.WriteLine("Kilometros recorridos: " + this.kilometrosRecorridos);
        }

        public void volverACero()
        {
            this.kilometrosRecorridos = 0;
        }

        public void agregarKilometro(int kilometros)
        {
            this.kilometrosRecorridos += kilometros;
        }
    }
}