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

namespace _007_CRUD
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ModelContainer object using the connection string found in the 'ModelContainer' section of the application configuration file.
        /// </summary>
        public ModelContainer() : base("name=ModelContainer", "ModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ModelContainer object.
        /// </summary>
        public ModelContainer(string connectionString) : base(connectionString, "ModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ModelContainer object.
        /// </summary>
        public ModelContainer(EntityConnection connection) : base(connection, "ModelContainer")
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
        public ObjectSet<Cliente> Clientes
        {
            get
            {
                if ((_Clientes == null))
                {
                    _Clientes = base.CreateObjectSet<Cliente>("Clientes");
                }
                return _Clientes;
            }
        }
        private ObjectSet<Cliente> _Clientes;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Clientes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClientes(Cliente cliente)
        {
            base.AddObject("Clientes", cliente);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Cliente")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cliente : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cliente object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        public static Cliente CreateCliente(global::System.Int32 id, global::System.String nome)
        {
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.Nome = nome;
            return cliente;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();

        #endregion
    
    }

    #endregion
    
}
