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
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("DatabaseOnlineShop.Model", "FK_BeanBag_BeanBagType", "BeanBagType", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Online_Shop_Babelfish.Models.BeanBagType), "BeanBag", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Online_Shop_Babelfish.Models.BeanBag), true)]

#endregion

namespace Online_Shop_Babelfish.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class DatabaseOnlineShopEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new DatabaseOnlineShopEntities object using the connection string found in the 'DatabaseOnlineShopEntities' section of the application configuration file.
        /// </summary>
        public DatabaseOnlineShopEntities() : base("name=DatabaseOnlineShopEntities", "DatabaseOnlineShopEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseOnlineShopEntities object.
        /// </summary>
        public DatabaseOnlineShopEntities(string connectionString) : base(connectionString, "DatabaseOnlineShopEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new DatabaseOnlineShopEntities object.
        /// </summary>
        public DatabaseOnlineShopEntities(EntityConnection connection) : base(connection, "DatabaseOnlineShopEntities")
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
        public ObjectSet<BeanBag> BeanBags
        {
            get
            {
                if ((_BeanBags == null))
                {
                    _BeanBags = base.CreateObjectSet<BeanBag>("BeanBags");
                }
                return _BeanBags;
            }
        }
        private ObjectSet<BeanBag> _BeanBags;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<BeanBagType> BeanBagTypes
        {
            get
            {
                if ((_BeanBagTypes == null))
                {
                    _BeanBagTypes = base.CreateObjectSet<BeanBagType>("BeanBagTypes");
                }
                return _BeanBagTypes;
            }
        }
        private ObjectSet<BeanBagType> _BeanBagTypes;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BeanBags EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBeanBags(BeanBag beanBag)
        {
            base.AddObject("BeanBags", beanBag);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the BeanBagTypes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBeanBagTypes(BeanBagType beanBagType)
        {
            base.AddObject("BeanBagTypes", beanBagType);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseOnlineShop.Model", Name="BeanBag")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BeanBag : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BeanBag object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        /// <param name="prize">Initial value of the Prize property.</param>
        /// <param name="dateCreated">Initial value of the DateCreated property.</param>
        /// <param name="beanBagTypeID">Initial value of the BeanBagTypeID property.</param>
        public static BeanBag CreateBeanBag(global::System.Int32 id, global::System.String name, global::System.String description, global::System.Int32 prize, global::System.DateTime dateCreated, global::System.Int32 beanBagTypeID)
        {
            BeanBag beanBag = new BeanBag();
            beanBag.ID = id;
            beanBag.Name = name;
            beanBag.Description = description;
            beanBag.Prize = prize;
            beanBag.DateCreated = dateCreated;
            beanBag.BeanBagTypeID = beanBagTypeID;
            return beanBag;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
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
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Prize
        {
            get
            {
                return _Prize;
            }
            set
            {
                OnPrizeChanging(value);
                ReportPropertyChanging("Prize");
                _Prize = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Prize");
                OnPrizeChanged();
            }
        }
        private global::System.Int32 _Prize;
        partial void OnPrizeChanging(global::System.Int32 value);
        partial void OnPrizeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private global::System.DateTime _DateCreated;
        partial void OnDateCreatedChanging(global::System.DateTime value);
        partial void OnDateCreatedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BeanBagTypeID
        {
            get
            {
                return _BeanBagTypeID;
            }
            set
            {
                OnBeanBagTypeIDChanging(value);
                ReportPropertyChanging("BeanBagTypeID");
                _BeanBagTypeID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BeanBagTypeID");
                OnBeanBagTypeIDChanged();
            }
        }
        private global::System.Int32 _BeanBagTypeID;
        partial void OnBeanBagTypeIDChanging(global::System.Int32 value);
        partial void OnBeanBagTypeIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseOnlineShop.Model", "FK_BeanBag_BeanBagType", "BeanBagType")]
        public BeanBagType BeanBagType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBagType>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBagType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBagType>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBagType").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BeanBagType> BeanBagTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBagType>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBagType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BeanBagType>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBagType", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DatabaseOnlineShop.Model", Name="BeanBagType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class BeanBagType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new BeanBagType object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="dateCreated">Initial value of the DateCreated property.</param>
        public static BeanBagType CreateBeanBagType(global::System.Int32 id, global::System.String name, global::System.DateTime dateCreated)
        {
            BeanBagType beanBagType = new BeanBagType();
            beanBagType.ID = id;
            beanBagType.Name = name;
            beanBagType.DateCreated = dateCreated;
            return beanBagType;
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateCreated
        {
            get
            {
                return _DateCreated;
            }
            set
            {
                OnDateCreatedChanging(value);
                ReportPropertyChanging("DateCreated");
                _DateCreated = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateCreated");
                OnDateCreatedChanged();
            }
        }
        private global::System.DateTime _DateCreated;
        partial void OnDateCreatedChanging(global::System.DateTime value);
        partial void OnDateCreatedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("DatabaseOnlineShop.Model", "FK_BeanBag_BeanBagType", "BeanBag")]
        public BeanBag BeanBag
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBag>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBag").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBag>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBag").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<BeanBag> BeanBagReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<BeanBag>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBag");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<BeanBag>("DatabaseOnlineShop.Model.FK_BeanBag_BeanBagType", "BeanBag", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
