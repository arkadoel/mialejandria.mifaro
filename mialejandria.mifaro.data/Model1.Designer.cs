﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace mialejandria.mifaro.data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MifaroLocalDBEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MifaroLocalDBEntities object using the connection string found in the 'MifaroLocalDBEntities' section of the application configuration file.
        /// </summary>
        public MifaroLocalDBEntities() : base("name=MifaroLocalDBEntities", "MifaroLocalDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MifaroLocalDBEntities object.
        /// </summary>
        public MifaroLocalDBEntities(string connectionString) : base(connectionString, "MifaroLocalDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MifaroLocalDBEntities object.
        /// </summary>
        public MifaroLocalDBEntities(EntityConnection connection) : base(connection, "MifaroLocalDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Configuracion> Configuraciones
        {
            get
            {
                if ((_Configuraciones == null))
                {
                    _Configuraciones = base.CreateObjectSet<Configuracion>("Configuraciones");
                }
                return _Configuraciones;
            }
        }
        private ObjectSet<Configuracion> _Configuraciones;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Configuraciones EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToConfiguraciones(Configuracion configuracion)
        {
            base.AddObject("Configuraciones", configuracion);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MifaroLocalDBModel", Name="Configuracion")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Configuracion : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Configuracion object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static Configuracion CreateConfiguracion(global::System.Int32 id)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.ID = id;
            return configuracion;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int32 _ID;
        partial void OnIDChanging(global::System.Int32 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                OnValorChanging(value);
                ReportPropertyChanging("Valor");
                _Valor = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Valor");
                OnValorChanged();
            }
        }
        private global::System.String _Valor;
        partial void OnValorChanging(global::System.String value);
        partial void OnValorChanged();

        #endregion
    
    }

    #endregion
    
}