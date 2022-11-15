﻿using Funcionalidad.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Funcionalidad.clases.Jugador;

namespace Funcionalidad
{
    public interface IPartida
    {


        public void Informacion(Partida partidaActual);

        public void ActualizarDatagrid(Partida partidaActual);

        public void FinalizarPartida(string Ganador);

    }
}
