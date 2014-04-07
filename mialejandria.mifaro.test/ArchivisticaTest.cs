using mialejandria.mifaro.logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using mialejandria.mifaro.data.Externo;
using System.Collections.Generic;

namespace mialejandria.mifaro.test
{
    
    
    /// <summary>
    ///This is a test class for ArchivisticaTest and is intended
    ///to contain all ArchivisticaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ArchivisticaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Archivistica Constructor
        ///</summary>
        [TestMethod()]
        public void ArchivisticaConstructorTest()
        {
            Archivistica target = new Archivistica();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GuardarEtiqueta
        ///</summary>
        [TestMethod()]
        public void GuardarEtiquetaTest()
        {
            EtiquetasUsuario etiqueta = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Archivistica.GuardarEtiqueta(etiqueta);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GuardarUnidadSimple
        ///</summary>
        [TestMethod()]
        public void GuardarUnidadSimpleTest()
        {
            UnidadSimple usimple = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = Archivistica.GuardarUnidadSimple(usimple);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ObtenerCodigoPadre
        ///</summary>
        [TestMethod()]
        public void ObtenerCodigoPadreTest()
        {
            string codigo = "ES.472178.GES99.RECSO.1.2.132.1.3.2.5.1";// TODO: Initialize to an appropriate value
            string expected = "ES.472178.GES99.RECSO.1.2.132.1.3.2.5"; // TODO: Initialize to an appropriate value
            string actual;
            actual = Archivistica.ObtenerCodigoPadre(codigo);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getEtiquetasUnidadSimple
        ///</summary>
        [TestMethod()]
        public void getEtiquetasUnidadSimpleTest()
        {
            string codigo = string.Empty; // TODO: Initialize to an appropriate value
            string usuario = string.Empty; // TODO: Initialize to an appropriate value
            List<EtiquetasUsuario> expected = null; // TODO: Initialize to an appropriate value
            List<EtiquetasUsuario> actual;
            actual = Archivistica.getEtiquetasUnidadSimple(codigo, usuario);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getFondos
        ///</summary>
        [TestMethod()]
        public void getFondosTest()
        {
            List<Fondo> expected = null; // TODO: Initialize to an appropriate value
            List<Fondo> actual;
            actual = Archivistica.getFondos();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSeries
        ///</summary>
        [TestMethod()]
        public void getSeriesTest()
        {
            List<Serie> expected = null; // TODO: Initialize to an appropriate value
            List<Serie> actual;
            actual = Archivistica.getSeries();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getUnidadSimpleByCodigo
        ///</summary>
        [TestMethod()]
        public void getUnidadSimpleByCodigoTest()
        {
            string codigoReferencia = string.Empty; // TODO: Initialize to an appropriate value
            UnidadSimple expected = null; // TODO: Initialize to an appropriate value
            UnidadSimple actual;
            actual = Archivistica.getUnidadSimpleByCodigo(codigoReferencia);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getUnidadesCompuestas
        ///</summary>
        [TestMethod()]
        public void getUnidadesCompuestasTest()
        {
            string codigoReferencia = string.Empty; // TODO: Initialize to an appropriate value
            List<UnidadCompuesta> expected = null; // TODO: Initialize to an appropriate value
            List<UnidadCompuesta> actual;
            actual = Archivistica.getUnidadesCompuestas(codigoReferencia);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getUnidadesSimples
        ///</summary>
        [TestMethod()]
        public void getUnidadesSimplesTest()
        {
            string codigoReferencia = string.Empty; // TODO: Initialize to an appropriate value
            List<UnidadSimple> expected = null; // TODO: Initialize to an appropriate value
            List<UnidadSimple> actual;
            actual = Archivistica.getUnidadesSimples(codigoReferencia);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
