﻿using System;
namespace Condos.Models
{
    public class RegistroDeAcceso
    {
        public int CondoID
        {
            get;
            set;
        }

        public string NombreInvitado
        {
            get;
            set;
        }

        public string Identificacion
        {
            get;
            set;
        }

        public string PlacaVehiculo
        {
            get;
            set;
        }

        public DateTime FechaAcceso
        {
            get;
            set;
        }

        public string NombreAutoriza
        {
            get;
            set;
        }
    }

}
