﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace razor_9mm.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class diiceas_mssqlEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new diiceas_mssqlEntities object using the connection string found in the 'diiceas_mssqlEntities' section of the application configuration file.
        /// </summary>
        public diiceas_mssqlEntities() : base("name=diiceas_mssqlEntities", "diiceas_mssqlEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new diiceas_mssqlEntities object.
        /// </summary>
        public diiceas_mssqlEntities(string connectionString) : base(connectionString, "diiceas_mssqlEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new diiceas_mssqlEntities object.
        /// </summary>
        public diiceas_mssqlEntities(EntityConnection connection) : base(connection, "diiceas_mssqlEntities")
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
        public ObjectSet<TestTable> TestTable
        {
            get
            {
                if ((_TestTable == null))
                {
                    _TestTable = base.CreateObjectSet<TestTable>("TestTable");
                }
                return _TestTable;
            }
        }
        private ObjectSet<TestTable> _TestTable;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TestTable EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTestTable(TestTable testTable)
        {
            base.AddObject("TestTable", testTable);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="diiceas_mssqlModel", Name="TestTable")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TestTable : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new TestTable object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        public static TestTable CreateTestTable(global::System.Int32 id)
        {
            TestTable testTable = new TestTable();
            testTable.ID = id;
            return testTable;
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
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
    }

    #endregion

    
}
