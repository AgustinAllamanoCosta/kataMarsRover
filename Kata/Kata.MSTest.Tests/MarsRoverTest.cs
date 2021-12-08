using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Kata.MSTest.Tests
{
    [TestClass]
    public class MarsRoverTest
    {

        [TestMethod]
        public void cuadnoCreoUnRoverSeLeAsignaUnaPosicionOrigenYUnaDireccionADondeMira() {

            int[] poss = { 99, 99 };
            string direccion = "N";

            var rover = new MarsRover(poss,direccion);

            Assert.AreEqual(poss, rover.posicion);
            Assert.AreEqual( direccion, rover.direccion);
        }

        [TestMethod]
        public void cuandoSeVaAEjecutarUnComandoEnUnRoverSeVerificaQueSeRecibeUnArrayDeCaracteres()
        {
            string[] comandos = {};
            int[] posicionSinUso = { 99, 99 };
            string direccionSinUso = "N";

            var rover = new MarsRover(posicionSinUso, direccionSinUso);

            bool resultado = rover.ejecutarComandos(comandos);

            Assert.IsTrue(resultado);
        }
    }
}
