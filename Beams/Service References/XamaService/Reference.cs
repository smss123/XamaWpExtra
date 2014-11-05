namespace Beams.XamaService
{
    using System.Runtime.Serialization;
    using System;

    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SystemUser", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class SystemUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string UserNameField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PasswordField;
        private System.Nullable<int> Person_IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string UserTokenField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string UserName
        {
            get
            {
                return UserNameField;
            }
            set
            {
                if ((object.ReferenceEquals(UserNameField, value) != true))
                {
                    UserNameField = value;
                    RaisePropertyChanged("UserName");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string Password
        {
            get
            {
                return PasswordField;
            }
            set
            {
                if ((object.ReferenceEquals(PasswordField, value) != true))
                {
                    PasswordField = value;
                    RaisePropertyChanged("Password");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 3)]
        public System.Nullable<int> Person_ID
        {
            get
            {
                return Person_IDField;
            }
            set
            {
                if ((Person_IDField.Equals(value) != true))
                {
                    Person_IDField = value;
                    RaisePropertyChanged("Person_ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string UserToken
        {
            get
            {
                return UserTokenField;
            }
            set
            {
                if ((object.ReferenceEquals(UserTokenField, value) != true))
                {
                    UserTokenField = value;
                    RaisePropertyChanged("UserToken");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "UserPermession", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class UserPermession : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        private System.Nullable<int> PermessionIDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PermessionValueField;
        private System.Nullable<int> UserIDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.SystemPermession SystemPermessionField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.SystemUser SystemUserField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public System.Nullable<int> PermessionID
        {
            get
            {
                return PermessionIDField;
            }
            set
            {
                if ((PermessionIDField.Equals(value) != true))
                {
                    PermessionIDField = value;
                    RaisePropertyChanged("PermessionID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PermessionValue
        {
            get
            {
                return PermessionValueField;
            }
            set
            {
                if ((object.ReferenceEquals(PermessionValueField, value) != true))
                {
                    PermessionValueField = value;
                    RaisePropertyChanged("PermessionValue");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public System.Nullable<int> UserID
        {
            get
            {
                return UserIDField;
            }
            set
            {
                if ((UserIDField.Equals(value) != true))
                {
                    UserIDField = value;
                    RaisePropertyChanged("UserID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public Beams.XamaService.SystemPermession SystemPermession
        {
            get
            {
                return SystemPermessionField;
            }
            set
            {
                if ((object.ReferenceEquals(SystemPermessionField, value) != true))
                {
                    SystemPermessionField = value;
                    RaisePropertyChanged("SystemPermession");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public Beams.XamaService.SystemUser SystemUser
        {
            get
            {
                return SystemUserField;
            }
            set
            {
                if ((object.ReferenceEquals(SystemUserField, value) != true))
                {
                    SystemUserField = value;
                    RaisePropertyChanged("SystemUser");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "SystemPermession", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class SystemPermession : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PermessionNameField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PermessionDescriptionField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PermessionName
        {
            get
            {
                return PermessionNameField;
            }
            set
            {
                if ((object.ReferenceEquals(PermessionNameField, value) != true))
                {
                    PermessionNameField = value;
                    RaisePropertyChanged("PermessionName");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string PermessionDescription
        {
            get
            {
                return PermessionDescriptionField;
            }
            set
            {
                if ((object.ReferenceEquals(PermessionDescriptionField, value) != true))
                {
                    PermessionDescriptionField = value;
                    RaisePropertyChanged("PermessionDescription");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "IDSender", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class IDSender : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string WhatsAppIDSenderField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PaskeyField;
        private System.Nullable<System.DateTime> CreatedDateField;
        private System.Nullable<int> User_IDField;
        private System.Nullable<int> Company_IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private byte[] whatsAppImgField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string WhatsAppStatusField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string IDSenderStatusField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string AutoReplayMsgField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.Company CompanyField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.SystemUser SystemUserField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string WhatsAppIDSender
        {
            get
            {
                return WhatsAppIDSenderField;
            }
            set
            {
                if ((object.ReferenceEquals(WhatsAppIDSenderField, value) != true))
                {
                    WhatsAppIDSenderField = value;
                    RaisePropertyChanged("WhatsAppIDSender");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string Paskey
        {
            get
            {
                return PaskeyField;
            }
            set
            {
                if ((object.ReferenceEquals(PaskeyField, value) != true))
                {
                    PaskeyField = value;
                    RaisePropertyChanged("Paskey");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 3)]
        public System.Nullable<System.DateTime> CreatedDate
        {
            get
            {
                return CreatedDateField;
            }
            set
            {
                if ((CreatedDateField.Equals(value) != true))
                {
                    CreatedDateField = value;
                    RaisePropertyChanged("CreatedDate");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public System.Nullable<int> User_ID
        {
            get
            {
                return User_IDField;
            }
            set
            {
                if ((User_IDField.Equals(value) != true))
                {
                    User_IDField = value;
                    RaisePropertyChanged("User_ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 5)]
        public System.Nullable<int> Company_ID
        {
            get
            {
                return Company_IDField;
            }
            set
            {
                if ((Company_IDField.Equals(value) != true))
                {
                    Company_IDField = value;
                    RaisePropertyChanged("Company_ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public byte[] whatsAppImg
        {
            get
            {
                return whatsAppImgField;
            }
            set
            {
                if ((object.ReferenceEquals(whatsAppImgField, value) != true))
                {
                    whatsAppImgField = value;
                    RaisePropertyChanged("whatsAppImg");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 7)]
        public string WhatsAppStatus
        {
            get
            {
                return WhatsAppStatusField;
            }
            set
            {
                if ((object.ReferenceEquals(WhatsAppStatusField, value) != true))
                {
                    WhatsAppStatusField = value;
                    RaisePropertyChanged("WhatsAppStatus");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string IDSenderStatus
        {
            get
            {
                return IDSenderStatusField;
            }
            set
            {
                if ((object.ReferenceEquals(IDSenderStatusField, value) != true))
                {
                    IDSenderStatusField = value;
                    RaisePropertyChanged("IDSenderStatus");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public string AutoReplayMsg
        {
            get
            {
                return AutoReplayMsgField;
            }
            set
            {
                if ((object.ReferenceEquals(AutoReplayMsgField, value) != true))
                {
                    AutoReplayMsgField = value;
                    RaisePropertyChanged("AutoReplayMsg");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 10)]
        public Beams.XamaService.Company Company
        {
            get
            {
                return CompanyField;
            }
            set
            {
                if ((object.ReferenceEquals(CompanyField, value) != true))
                {
                    CompanyField = value;
                    RaisePropertyChanged("Company");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 11)]
        public Beams.XamaService.SystemUser SystemUser
        {
            get
            {
                return SystemUserField;
            }
            set
            {
                if ((object.ReferenceEquals(SystemUserField, value) != true))
                {
                    SystemUserField = value;
                    RaisePropertyChanged("SystemUser");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Company", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class Company : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string CompanyNameField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string CompanyAddressField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string CompanyActivtyField;
        private int Person_IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private System.Collections.Generic.List<Beams.XamaService.IDSender> IDSendersField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.Person PersonField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string CompanyName
        {
            get
            {
                return CompanyNameField;
            }
            set
            {
                if ((object.ReferenceEquals(CompanyNameField, value) != true))
                {
                    CompanyNameField = value;
                    RaisePropertyChanged("CompanyName");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string CompanyAddress
        {
            get
            {
                return CompanyAddressField;
            }
            set
            {
                if ((object.ReferenceEquals(CompanyAddressField, value) != true))
                {
                    CompanyAddressField = value;
                    RaisePropertyChanged("CompanyAddress");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string CompanyActivty
        {
            get
            {
                return CompanyActivtyField;
            }
            set
            {
                if ((object.ReferenceEquals(CompanyActivtyField, value) != true))
                {
                    CompanyActivtyField = value;
                    RaisePropertyChanged("CompanyActivty");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public int Person_ID
        {
            get
            {
                return Person_IDField;
            }
            set
            {
                if ((Person_IDField.Equals(value) != true))
                {
                    Person_IDField = value;
                    RaisePropertyChanged("Person_ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public System.Collections.Generic.List<Beams.XamaService.IDSender> IDSenders
        {
            get
            {
                return IDSendersField;
            }
            set
            {
                if ((object.ReferenceEquals(IDSendersField, value) != true))
                {
                    IDSendersField = value;
                    RaisePropertyChanged("IDSenders");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 6)]
        public Beams.XamaService.Person Person
        {
            get
            {
                return PersonField;
            }
            set
            {
                if ((object.ReferenceEquals(PersonField, value) != true))
                {
                    PersonField = value;
                    RaisePropertyChanged("Person");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Person", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PersonNameField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PersonaltyTypeField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PersonaltyNumberField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string AddressField;
        private System.Nullable<int> AgeField;
        private System.Nullable<System.DateTime> BirthDateField;
        private System.Nullable<System.DateTime> HereDateField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string GenderField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private System.Collections.Generic.List<Beams.XamaService.Contact> ContactsField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PersonName
        {
            get
            {
                return PersonNameField;
            }
            set
            {
                if ((object.ReferenceEquals(PersonNameField, value) != true))
                {
                    PersonNameField = value;
                    RaisePropertyChanged("PersonName");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PersonaltyType
        {
            get
            {
                return PersonaltyTypeField;
            }
            set
            {
                if ((object.ReferenceEquals(PersonaltyTypeField, value) != true))
                {
                    PersonaltyTypeField = value;
                    RaisePropertyChanged("PersonaltyType");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string PersonaltyNumber
        {
            get
            {
                return PersonaltyNumberField;
            }
            set
            {
                if ((object.ReferenceEquals(PersonaltyNumberField, value) != true))
                {
                    PersonaltyNumberField = value;
                    RaisePropertyChanged("PersonaltyNumber");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 4)]
        public string Address
        {
            get
            {
                return AddressField;
            }
            set
            {
                if ((object.ReferenceEquals(AddressField, value) != true))
                {
                    AddressField = value;
                    RaisePropertyChanged("Address");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 5)]
        public System.Nullable<int> Age
        {
            get
            {
                return AgeField;
            }
            set
            {
                if ((AgeField.Equals(value) != true))
                {
                    AgeField = value;
                    RaisePropertyChanged("Age");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 6)]
        public System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return BirthDateField;
            }
            set
            {
                if ((BirthDateField.Equals(value) != true))
                {
                    BirthDateField = value;
                    RaisePropertyChanged("BirthDate");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 7)]
        public System.Nullable<System.DateTime> HereDate
        {
            get
            {
                return HereDateField;
            }
            set
            {
                if ((HereDateField.Equals(value) != true))
                {
                    HereDateField = value;
                    RaisePropertyChanged("HereDate");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 8)]
        public string Gender
        {
            get
            {
                return GenderField;
            }
            set
            {
                if ((object.ReferenceEquals(GenderField, value) != true))
                {
                    GenderField = value;
                    RaisePropertyChanged("Gender");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 9)]
        public System.Collections.Generic.List<Beams.XamaService.Contact> Contacts
        {
            get
            {
                return ContactsField;
            }
            set
            {
                if ((object.ReferenceEquals(ContactsField, value) != true))
                {
                    ContactsField = value;
                    RaisePropertyChanged("Contacts");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Contact", Namespace = "http://xprema.net")]
    [System.SerializableAttribute]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {
        [System.NonSerializedAttribute]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        private int IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string PhoneNumberField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string EmailField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private string WebSiteField;
        private int Person_IDField;
        [System.Runtime.Serialization.OptionalFieldAttribute]
        private Beams.XamaService.Person PersonField;
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataField;
            }
            set
            {
                extensionDataField = value;
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true)]
        public int ID
        {
            get
            {
                return IDField;
            }
            set
            {
                if ((IDField.Equals(value) != true))
                {
                    IDField = value;
                    RaisePropertyChanged("ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false)]
        public string PhoneNumber
        {
            get
            {
                return PhoneNumberField;
            }
            set
            {
                if ((object.ReferenceEquals(PhoneNumberField, value) != true))
                {
                    PhoneNumberField = value;
                    RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 2)]
        public string Email
        {
            get
            {
                return EmailField;
            }
            set
            {
                if ((object.ReferenceEquals(EmailField, value) != true))
                {
                    EmailField = value;
                    RaisePropertyChanged("Email");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 3)]
        public string WebSite
        {
            get
            {
                return WebSiteField;
            }
            set
            {
                if ((object.ReferenceEquals(WebSiteField, value) != true))
                {
                    WebSiteField = value;
                    RaisePropertyChanged("WebSite");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = true, Order = 4)]
        public int Person_ID
        {
            get
            {
                return Person_IDField;
            }
            set
            {
                if ((Person_IDField.Equals(value) != true))
                {
                    Person_IDField = value;
                    RaisePropertyChanged("Person_ID");
                }
            }
        }
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 5)]
        public Beams.XamaService.Person Person
        {
            get
            {
                return PersonField;
            }
            set
            {
                if ((object.ReferenceEquals(PersonField, value) != true))
                {
                    PersonField = value;
                    RaisePropertyChanged("Person");
                }
            }
        }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://xprema.net", ConfigurationName = "XamaService.XamaWhatsAppServiceSoap")]
    public interface XamaWhatsAppServiceSoap
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/HelloWorld", ReplyAction = "*")]
        Beams.XamaService.HelloWorldResponse HelloWorld(Beams.XamaService.HelloWorldRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/HelloWorld", ReplyAction = "*")]
        System.IAsyncResult BeginHelloWorld(Beams.XamaService.HelloWorldRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.HelloWorldResponse EndHelloWorld(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/GetServiceStatus", ReplyAction = "*")]
        Beams.XamaService.GetServiceStatusResponse GetServiceStatus(Beams.XamaService.GetServiceStatusRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/GetServiceStatus", ReplyAction = "*")]
        System.IAsyncResult BeginGetServiceStatus(Beams.XamaService.GetServiceStatusRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.GetServiceStatusResponse EndGetServiceStatus(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/StartService", ReplyAction = "*")]
        void StartService();
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/StartService", ReplyAction = "*")]
        System.IAsyncResult BeginStartService(System.AsyncCallback callback, object asyncState);
        void EndStartService(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/StopService", ReplyAction = "*")]
        void StopService();
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/StopService", ReplyAction = "*")]
        System.IAsyncResult BeginStopService(System.AsyncCallback callback, object asyncState);
        void EndStopService(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/Login", ReplyAction = "*")]
        Beams.XamaService.LoginResponse Login(Beams.XamaService.LoginRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/Login", ReplyAction = "*")]
        System.IAsyncResult BeginLogin(Beams.XamaService.LoginRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.LoginResponse EndLogin(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/GetUserPermession", ReplyAction = "*")]
        Beams.XamaService.GetUserPermessionResponse GetUserPermession(Beams.XamaService.GetUserPermessionRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/GetUserPermession", ReplyAction = "*")]
        System.IAsyncResult BeginGetUserPermession(Beams.XamaService.GetUserPermessionRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.GetUserPermessionResponse EndGetUserPermession(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/IDSenderSave", ReplyAction = "*")]
        Beams.XamaService.IDSenderSaveResponse IDSenderSave(Beams.XamaService.IDSenderSaveRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/IDSenderSave", ReplyAction = "*")]
        System.IAsyncResult BeginIDSenderSave(Beams.XamaService.IDSenderSaveRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.IDSenderSaveResponse EndIDSenderSave(System.IAsyncResult result);
        [System.ServiceModel.OperationContractAttribute(Action = "http://xprema.net/IDSenderGetAll", ReplyAction = "*")]
        Beams.XamaService.IDSenderGetAllResponse IDSenderGetAll(Beams.XamaService.IDSenderGetAllRequest request);
        [System.ServiceModel.OperationContractAttribute(AsyncPattern = true, Action = "http://xprema.net/IDSenderGetAll", ReplyAction = "*")]
        System.IAsyncResult BeginIDSenderGetAll(Beams.XamaService.IDSenderGetAllRequest request, System.AsyncCallback callback, object asyncState);
        Beams.XamaService.IDSenderGetAllResponse EndIDSenderGetAll(System.IAsyncResult result);
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class HelloWorldRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "HelloWorld", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.HelloWorldRequestBody Body;
        public HelloWorldRequest()
        {
        }
        public HelloWorldRequest(Beams.XamaService.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class HelloWorldRequestBody
    {
        public HelloWorldRequestBody()
        {
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class HelloWorldResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "HelloWorldResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.HelloWorldResponseBody Body;
        public HelloWorldResponse()
        {
        }
        public HelloWorldResponse(Beams.XamaService.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class HelloWorldResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string HelloWorldResult;
        public HelloWorldResponseBody()
        {
        }
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetServiceStatusRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetServiceStatus", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.GetServiceStatusRequestBody Body;
        public GetServiceStatusRequest()
        {
        }
        public GetServiceStatusRequest(Beams.XamaService.GetServiceStatusRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class GetServiceStatusRequestBody
    {
        public GetServiceStatusRequestBody()
        {
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetServiceStatusResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetServiceStatusResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.GetServiceStatusResponseBody Body;
        public GetServiceStatusResponse()
        {
        }
        public GetServiceStatusResponse(Beams.XamaService.GetServiceStatusResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class GetServiceStatusResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string GetServiceStatusResult;
        public GetServiceStatusResponseBody()
        {
        }
        public GetServiceStatusResponseBody(string GetServiceStatusResult)
        {
            this.GetServiceStatusResult = GetServiceStatusResult;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class LoginRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "Login", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.LoginRequestBody Body;
        public LoginRequest()
        {
        }
        public LoginRequest(Beams.XamaService.LoginRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class LoginRequestBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string user;
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 1)]
        public string pwd;
        public LoginRequestBody()
        {
        }
        public LoginRequestBody(string user, string pwd)
        {
            this.user = user;
            this.pwd = pwd;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class LoginResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "LoginResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.LoginResponseBody Body;
        public LoginResponse()
        {
        }
        public LoginResponse(Beams.XamaService.LoginResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class LoginResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public Beams.XamaService.SystemUser LoginResult;
        public LoginResponseBody()
        {
        }
        public LoginResponseBody(Beams.XamaService.SystemUser LoginResult)
        {
            this.LoginResult = LoginResult;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetUserPermessionRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetUserPermession", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.GetUserPermessionRequestBody Body;
        public GetUserPermessionRequest()
        {
        }
        public GetUserPermessionRequest(Beams.XamaService.GetUserPermessionRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class GetUserPermessionRequestBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public string userToken;
        public GetUserPermessionRequestBody()
        {
        }
        public GetUserPermessionRequestBody(string userToken)
        {
            this.userToken = userToken;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class GetUserPermessionResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "GetUserPermessionResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.GetUserPermessionResponseBody Body;
        public GetUserPermessionResponse()
        {
        }
        public GetUserPermessionResponse(Beams.XamaService.GetUserPermessionResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class GetUserPermessionResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public System.Collections.Generic.List<Beams.XamaService.UserPermession> GetUserPermessionResult;
        public GetUserPermessionResponseBody()
        {
        }
        public GetUserPermessionResponseBody(System.Collections.Generic.List<Beams.XamaService.UserPermession> GetUserPermessionResult)
        {
            this.GetUserPermessionResult = GetUserPermessionResult;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class IDSenderSaveRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "IDSenderSave", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.IDSenderSaveRequestBody Body;
        public IDSenderSaveRequest()
        {
        }
        public IDSenderSaveRequest(Beams.XamaService.IDSenderSaveRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class IDSenderSaveRequestBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public Beams.XamaService.IDSender snd;
        public IDSenderSaveRequestBody()
        {
        }
        public IDSenderSaveRequestBody(Beams.XamaService.IDSender snd)
        {
            this.snd = snd;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class IDSenderSaveResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "IDSenderSaveResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.IDSenderSaveResponseBody Body;
        public IDSenderSaveResponse()
        {
        }
        public IDSenderSaveResponse(Beams.XamaService.IDSenderSaveResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class IDSenderSaveResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(Order = 0)]
        public bool IDSenderSaveResult;
        public IDSenderSaveResponseBody()
        {
        }
        public IDSenderSaveResponseBody(bool IDSenderSaveResult)
        {
            this.IDSenderSaveResult = IDSenderSaveResult;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class IDSenderGetAllRequest
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "IDSenderGetAll", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.IDSenderGetAllRequestBody Body;
        public IDSenderGetAllRequest()
        {
        }
        public IDSenderGetAllRequest(Beams.XamaService.IDSenderGetAllRequestBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class IDSenderGetAllRequestBody
    {
        public IDSenderGetAllRequestBody()
        {
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped = false)]
    public partial class IDSenderGetAllResponse
    {
        [System.ServiceModel.MessageBodyMemberAttribute(Name = "IDSenderGetAllResponse", Namespace = "http://xprema.net", Order = 0)]
        public Beams.XamaService.IDSenderGetAllResponseBody Body;
        public IDSenderGetAllResponse()
        {
        }
        public IDSenderGetAllResponse(Beams.XamaService.IDSenderGetAllResponseBody Body)
        {
            this.Body = Body;
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace = "http://xprema.net")]
    public partial class IDSenderGetAllResponseBody
    {
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Order = 0)]
        public System.Collections.Generic.List<Beams.XamaService.IDSender> IDSenderGetAllResult;
        public IDSenderGetAllResponseBody()
        {
        }
        public IDSenderGetAllResponseBody(System.Collections.Generic.List<Beams.XamaService.IDSender> IDSenderGetAllResult)
        {
            this.IDSenderGetAllResult = IDSenderGetAllResult;
        }
    }
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface XamaWhatsAppServiceSoapChannel : Beams.XamaService.XamaWhatsAppServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public string Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((string)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetServiceStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public GetServiceStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public string Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((string)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public Beams.XamaService.SystemUser Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((Beams.XamaService.SystemUser)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUserPermessionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public GetUserPermessionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public System.Collections.Generic.List<Beams.XamaService.UserPermession> Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<Beams.XamaService.UserPermession>)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IDSenderSaveCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public IDSenderSaveCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public bool Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((bool)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IDSenderGetAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        private object[] results;
        public IDSenderGetAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }
        public System.Collections.Generic.List<Beams.XamaService.IDSender> Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<Beams.XamaService.IDSender>)(results[0]));
            }
        }
    }
    [System.Diagnostics.DebuggerStepThroughAttribute]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XamaWhatsAppServiceSoapClient : System.ServiceModel.ClientBase<Beams.XamaService.XamaWhatsAppServiceSoap>, Beams.XamaService.XamaWhatsAppServiceSoap
    {
        private BeginOperationDelegate onBeginHelloWorldDelegate;
        private EndOperationDelegate onEndHelloWorldDelegate;
        private System.Threading.SendOrPostCallback onHelloWorldCompletedDelegate;
        private BeginOperationDelegate onBeginGetServiceStatusDelegate;
        private EndOperationDelegate onEndGetServiceStatusDelegate;
        private System.Threading.SendOrPostCallback onGetServiceStatusCompletedDelegate;
        private BeginOperationDelegate onBeginStartServiceDelegate;
        private EndOperationDelegate onEndStartServiceDelegate;
        private System.Threading.SendOrPostCallback onStartServiceCompletedDelegate;
        private BeginOperationDelegate onBeginStopServiceDelegate;
        private EndOperationDelegate onEndStopServiceDelegate;
        private System.Threading.SendOrPostCallback onStopServiceCompletedDelegate;
        private BeginOperationDelegate onBeginLoginDelegate;
        private EndOperationDelegate onEndLoginDelegate;
        private System.Threading.SendOrPostCallback onLoginCompletedDelegate;
        private BeginOperationDelegate onBeginGetUserPermessionDelegate;
        private EndOperationDelegate onEndGetUserPermessionDelegate;
        private System.Threading.SendOrPostCallback onGetUserPermessionCompletedDelegate;
        private BeginOperationDelegate onBeginIDSenderSaveDelegate;
        private EndOperationDelegate onEndIDSenderSaveDelegate;
        private System.Threading.SendOrPostCallback onIDSenderSaveCompletedDelegate;
        private BeginOperationDelegate onBeginIDSenderGetAllDelegate;
        private EndOperationDelegate onEndIDSenderGetAllDelegate;
        private System.Threading.SendOrPostCallback onIDSenderGetAllCompletedDelegate;
        public XamaWhatsAppServiceSoapClient()
        {
        }
        public XamaWhatsAppServiceSoapClient(string endpointConfigurationName)
            :
            base(endpointConfigurationName)
        {
        }
        public XamaWhatsAppServiceSoapClient(string endpointConfigurationName, string remoteAddress)
            :
            base(endpointConfigurationName, remoteAddress)
        {
        }
        public XamaWhatsAppServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress)
            :
            base(endpointConfigurationName, remoteAddress)
        {
        }
        public XamaWhatsAppServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress)
            :
            base(binding, remoteAddress)
        {
        }
        public event System.EventHandler<HelloWorldCompletedEventArgs> HelloWorldCompleted;
        public event System.EventHandler<GetServiceStatusCompletedEventArgs> GetServiceStatusCompleted;
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> StartServiceCompleted;
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> StopServiceCompleted;
        public event System.EventHandler<LoginCompletedEventArgs> LoginCompleted;
        public event System.EventHandler<GetUserPermessionCompletedEventArgs> GetUserPermessionCompleted;
        public event System.EventHandler<IDSenderSaveCompletedEventArgs> IDSenderSaveCompleted;
        public event System.EventHandler<IDSenderGetAllCompletedEventArgs> IDSenderGetAllCompleted;
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.HelloWorldResponse Beams.XamaService.XamaWhatsAppServiceSoap.HelloWorld(Beams.XamaService.HelloWorldRequest request)
        {
            return base.Channel.HelloWorld(request);
        }
        public string HelloWorld()
        {
            var inValue = new Beams.XamaService.HelloWorldRequest();
            inValue.Body = new Beams.XamaService.HelloWorldRequestBody();
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginHelloWorld(Beams.XamaService.HelloWorldRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginHelloWorld(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.HelloWorldRequest();
            inValue.Body = new Beams.XamaService.HelloWorldRequestBody();
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginHelloWorld(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.HelloWorldResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndHelloWorld(System.IAsyncResult result)
        {
            return base.Channel.EndHelloWorld(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHelloWorld(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndHelloWorld(result);
            return retVal.Body.HelloWorldResult;
        }
        private System.IAsyncResult OnBeginHelloWorld(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return BeginHelloWorld(callback, asyncState);
        }
        private object[] OnEndHelloWorld(System.IAsyncResult result)
        {
            var retVal = EndHelloWorld(result);
            return new object[] {
                    retVal };
        }
        private void OnHelloWorldCompleted(object state)
        {
            if ((HelloWorldCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void HelloWorldAsync()
        {
            HelloWorldAsync(null);
        }
        public void HelloWorldAsync(object userState)
        {
            if ((onBeginHelloWorldDelegate == null))
            {
                onBeginHelloWorldDelegate = new BeginOperationDelegate(OnBeginHelloWorld);
            }
            if ((onEndHelloWorldDelegate == null))
            {
                onEndHelloWorldDelegate = new EndOperationDelegate(OnEndHelloWorld);
            }
            if ((onHelloWorldCompletedDelegate == null))
            {
                onHelloWorldCompletedDelegate = new System.Threading.SendOrPostCallback(OnHelloWorldCompleted);
            }
            base.InvokeAsync(onBeginHelloWorldDelegate, null, onEndHelloWorldDelegate, onHelloWorldCompletedDelegate, userState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.GetServiceStatusResponse Beams.XamaService.XamaWhatsAppServiceSoap.GetServiceStatus(Beams.XamaService.GetServiceStatusRequest request)
        {
            return base.Channel.GetServiceStatus(request);
        }
        public string GetServiceStatus()
        {
            var inValue = new Beams.XamaService.GetServiceStatusRequest();
            inValue.Body = new Beams.XamaService.GetServiceStatusRequestBody();
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).GetServiceStatus(inValue);
            return retVal.Body.GetServiceStatusResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginGetServiceStatus(Beams.XamaService.GetServiceStatusRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetServiceStatus(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetServiceStatus(System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.GetServiceStatusRequest();
            inValue.Body = new Beams.XamaService.GetServiceStatusRequestBody();
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginGetServiceStatus(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.GetServiceStatusResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndGetServiceStatus(System.IAsyncResult result)
        {
            return base.Channel.EndGetServiceStatus(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetServiceStatus(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndGetServiceStatus(result);
            return retVal.Body.GetServiceStatusResult;
        }
        private System.IAsyncResult OnBeginGetServiceStatus(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return BeginGetServiceStatus(callback, asyncState);
        }
        private object[] OnEndGetServiceStatus(System.IAsyncResult result)
        {
            var retVal = EndGetServiceStatus(result);
            return new object[] {
                    retVal };
        }
        private void OnGetServiceStatusCompleted(object state)
        {
            if ((GetServiceStatusCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                GetServiceStatusCompleted(this, new GetServiceStatusCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void GetServiceStatusAsync()
        {
            GetServiceStatusAsync(null);
        }
        public void GetServiceStatusAsync(object userState)
        {
            if ((onBeginGetServiceStatusDelegate == null))
            {
                onBeginGetServiceStatusDelegate = new BeginOperationDelegate(OnBeginGetServiceStatus);
            }
            if ((onEndGetServiceStatusDelegate == null))
            {
                onEndGetServiceStatusDelegate = new EndOperationDelegate(OnEndGetServiceStatus);
            }
            if ((onGetServiceStatusCompletedDelegate == null))
            {
                onGetServiceStatusCompletedDelegate = new System.Threading.SendOrPostCallback(OnGetServiceStatusCompleted);
            }
            base.InvokeAsync(onBeginGetServiceStatusDelegate, null, onEndGetServiceStatusDelegate, onGetServiceStatusCompletedDelegate, userState);
        }
        public void StartService()
        {
            base.Channel.StartService();
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginStartService(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginStartService(callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndStartService(System.IAsyncResult result)
        {
            base.Channel.EndStartService(result);
        }
        private System.IAsyncResult OnBeginStartService(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return BeginStartService(callback, asyncState);
        }
        private object[] OnEndStartService(System.IAsyncResult result)
        {
            EndStartService(result);
            return null;
        }
        private void OnStartServiceCompleted(object state)
        {
            if ((StartServiceCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                StartServiceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        public void StartServiceAsync()
        {
            StartServiceAsync(null);
        }
        public void StartServiceAsync(object userState)
        {
            if ((onBeginStartServiceDelegate == null))
            {
                onBeginStartServiceDelegate = new BeginOperationDelegate(OnBeginStartService);
            }
            if ((onEndStartServiceDelegate == null))
            {
                onEndStartServiceDelegate = new EndOperationDelegate(OnEndStartService);
            }
            if ((onStartServiceCompletedDelegate == null))
            {
                onStartServiceCompletedDelegate = new System.Threading.SendOrPostCallback(OnStartServiceCompleted);
            }
            base.InvokeAsync(onBeginStartServiceDelegate, null, onEndStartServiceDelegate, onStartServiceCompletedDelegate, userState);
        }
        public void StopService()
        {
            base.Channel.StopService();
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginStopService(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginStopService(callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndStopService(System.IAsyncResult result)
        {
            base.Channel.EndStopService(result);
        }
        private System.IAsyncResult OnBeginStopService(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return BeginStopService(callback, asyncState);
        }
        private object[] OnEndStopService(System.IAsyncResult result)
        {
            EndStopService(result);
            return null;
        }
        private void OnStopServiceCompleted(object state)
        {
            if ((StopServiceCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                StopServiceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        public void StopServiceAsync()
        {
            StopServiceAsync(null);
        }
        public void StopServiceAsync(object userState)
        {
            if ((onBeginStopServiceDelegate == null))
            {
                onBeginStopServiceDelegate = new BeginOperationDelegate(OnBeginStopService);
            }
            if ((onEndStopServiceDelegate == null))
            {
                onEndStopServiceDelegate = new EndOperationDelegate(OnEndStopService);
            }
            if ((onStopServiceCompletedDelegate == null))
            {
                onStopServiceCompletedDelegate = new System.Threading.SendOrPostCallback(OnStopServiceCompleted);
            }
            base.InvokeAsync(onBeginStopServiceDelegate, null, onEndStopServiceDelegate, onStopServiceCompletedDelegate, userState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.LoginResponse Beams.XamaService.XamaWhatsAppServiceSoap.Login(Beams.XamaService.LoginRequest request)
        {
            return base.Channel.Login(request);
        }
        public Beams.XamaService.SystemUser Login(string user, string pwd)
        {
            var inValue = new Beams.XamaService.LoginRequest();
            inValue.Body = new Beams.XamaService.LoginRequestBody();
            inValue.Body.user = user;
            inValue.Body.pwd = pwd;
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginLogin(Beams.XamaService.LoginRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginLogin(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginLogin(string user, string pwd, System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.LoginRequest();
            inValue.Body = new Beams.XamaService.LoginRequestBody();
            inValue.Body.user = user;
            inValue.Body.pwd = pwd;
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginLogin(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.LoginResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndLogin(System.IAsyncResult result)
        {
            return base.Channel.EndLogin(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public Beams.XamaService.SystemUser EndLogin(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndLogin(result);
            return retVal.Body.LoginResult;
        }
        private System.IAsyncResult OnBeginLogin(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            var user = ((string)(inValues[0]));
            var pwd = ((string)(inValues[1]));
            return BeginLogin(user, pwd, callback, asyncState);
        }
        private object[] OnEndLogin(System.IAsyncResult result)
        {
            var retVal = EndLogin(result);
            return new object[] {
                    retVal };
        }
        private void OnLoginCompleted(object state)
        {
            if ((LoginCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                LoginCompleted(this, new LoginCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void LoginAsync(string user, string pwd)
        {
            LoginAsync(user, pwd, null);
        }
        public void LoginAsync(string user, string pwd, object userState)
        {
            if ((onBeginLoginDelegate == null))
            {
                onBeginLoginDelegate = new BeginOperationDelegate(OnBeginLogin);
            }
            if ((onEndLoginDelegate == null))
            {
                onEndLoginDelegate = new EndOperationDelegate(OnEndLogin);
            }
            if ((onLoginCompletedDelegate == null))
            {
                onLoginCompletedDelegate = new System.Threading.SendOrPostCallback(OnLoginCompleted);
            }
            base.InvokeAsync(onBeginLoginDelegate, new object[] {
                        user,
                        pwd }, onEndLoginDelegate, onLoginCompletedDelegate, userState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.GetUserPermessionResponse Beams.XamaService.XamaWhatsAppServiceSoap.GetUserPermession(Beams.XamaService.GetUserPermessionRequest request)
        {
            return base.Channel.GetUserPermession(request);
        }
        public System.Collections.Generic.List<Beams.XamaService.UserPermession> GetUserPermession(string userToken)
        {
            var inValue = new Beams.XamaService.GetUserPermessionRequest();
            inValue.Body = new Beams.XamaService.GetUserPermessionRequestBody();
            inValue.Body.userToken = userToken;
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).GetUserPermession(inValue);
            return retVal.Body.GetUserPermessionResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginGetUserPermession(Beams.XamaService.GetUserPermessionRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginGetUserPermession(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetUserPermession(string userToken, System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.GetUserPermessionRequest();
            inValue.Body = new Beams.XamaService.GetUserPermessionRequestBody();
            inValue.Body.userToken = userToken;
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginGetUserPermession(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.GetUserPermessionResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndGetUserPermession(System.IAsyncResult result)
        {
            return base.Channel.EndGetUserPermession(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<Beams.XamaService.UserPermession> EndGetUserPermession(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndGetUserPermession(result);
            return retVal.Body.GetUserPermessionResult;
        }
        private System.IAsyncResult OnBeginGetUserPermession(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            var userToken = ((string)(inValues[0]));
            return BeginGetUserPermession(userToken, callback, asyncState);
        }
        private object[] OnEndGetUserPermession(System.IAsyncResult result)
        {
            var retVal = EndGetUserPermession(result);
            return new object[] {
                    retVal };
        }
        private void OnGetUserPermessionCompleted(object state)
        {
            if ((GetUserPermessionCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                GetUserPermessionCompleted(this, new GetUserPermessionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void GetUserPermessionAsync(string userToken)
        {
            GetUserPermessionAsync(userToken, null);
        }
        public void GetUserPermessionAsync(string userToken, object userState)
        {
            if ((onBeginGetUserPermessionDelegate == null))
            {
                onBeginGetUserPermessionDelegate = new BeginOperationDelegate(OnBeginGetUserPermession);
            }
            if ((onEndGetUserPermessionDelegate == null))
            {
                onEndGetUserPermessionDelegate = new EndOperationDelegate(OnEndGetUserPermession);
            }
            if ((onGetUserPermessionCompletedDelegate == null))
            {
                onGetUserPermessionCompletedDelegate = new System.Threading.SendOrPostCallback(OnGetUserPermessionCompleted);
            }
            base.InvokeAsync(onBeginGetUserPermessionDelegate, new object[] {
                        userToken }, onEndGetUserPermessionDelegate, onGetUserPermessionCompletedDelegate, userState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.IDSenderSaveResponse Beams.XamaService.XamaWhatsAppServiceSoap.IDSenderSave(Beams.XamaService.IDSenderSaveRequest request)
        {
            return base.Channel.IDSenderSave(request);
        }
        public bool IDSenderSave(Beams.XamaService.IDSender snd)
        {
            var inValue = new Beams.XamaService.IDSenderSaveRequest();
            inValue.Body = new Beams.XamaService.IDSenderSaveRequestBody();
            inValue.Body.snd = snd;
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).IDSenderSave(inValue);
            return retVal.Body.IDSenderSaveResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginIDSenderSave(Beams.XamaService.IDSenderSaveRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginIDSenderSave(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginIDSenderSave(Beams.XamaService.IDSender snd, System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.IDSenderSaveRequest();
            inValue.Body = new Beams.XamaService.IDSenderSaveRequestBody();
            inValue.Body.snd = snd;
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginIDSenderSave(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.IDSenderSaveResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndIDSenderSave(System.IAsyncResult result)
        {
            return base.Channel.EndIDSenderSave(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndIDSenderSave(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndIDSenderSave(result);
            return retVal.Body.IDSenderSaveResult;
        }
        private System.IAsyncResult OnBeginIDSenderSave(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            var snd = ((Beams.XamaService.IDSender)(inValues[0]));
            return BeginIDSenderSave(snd, callback, asyncState);
        }
        private object[] OnEndIDSenderSave(System.IAsyncResult result)
        {
            var retVal = EndIDSenderSave(result);
            return new object[] {
                    retVal };
        }
        private void OnIDSenderSaveCompleted(object state)
        {
            if ((IDSenderSaveCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                IDSenderSaveCompleted(this, new IDSenderSaveCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void IDSenderSaveAsync(Beams.XamaService.IDSender snd)
        {
            IDSenderSaveAsync(snd, null);
        }
        public void IDSenderSaveAsync(Beams.XamaService.IDSender snd, object userState)
        {
            if ((onBeginIDSenderSaveDelegate == null))
            {
                onBeginIDSenderSaveDelegate = new BeginOperationDelegate(OnBeginIDSenderSave);
            }
            if ((onEndIDSenderSaveDelegate == null))
            {
                onEndIDSenderSaveDelegate = new EndOperationDelegate(OnEndIDSenderSave);
            }
            if ((onIDSenderSaveCompletedDelegate == null))
            {
                onIDSenderSaveCompletedDelegate = new System.Threading.SendOrPostCallback(OnIDSenderSaveCompleted);
            }
            base.InvokeAsync(onBeginIDSenderSaveDelegate, new object[] {
                        snd }, onEndIDSenderSaveDelegate, onIDSenderSaveCompletedDelegate, userState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.IDSenderGetAllResponse Beams.XamaService.XamaWhatsAppServiceSoap.IDSenderGetAll(Beams.XamaService.IDSenderGetAllRequest request)
        {
            return base.Channel.IDSenderGetAll(request);
        }
        public System.Collections.Generic.List<Beams.XamaService.IDSender> IDSenderGetAll()
        {
            var inValue = new Beams.XamaService.IDSenderGetAllRequest();
            inValue.Body = new Beams.XamaService.IDSenderGetAllRequestBody();
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).IDSenderGetAll(inValue);
            return retVal.Body.IDSenderGetAllResult;
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult Beams.XamaService.XamaWhatsAppServiceSoap.BeginIDSenderGetAll(Beams.XamaService.IDSenderGetAllRequest request, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginIDSenderGetAll(request, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginIDSenderGetAll(System.AsyncCallback callback, object asyncState)
        {
            var inValue = new Beams.XamaService.IDSenderGetAllRequest();
            inValue.Body = new Beams.XamaService.IDSenderGetAllRequestBody();
            return ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).BeginIDSenderGetAll(inValue, callback, asyncState);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Beams.XamaService.IDSenderGetAllResponse Beams.XamaService.XamaWhatsAppServiceSoap.EndIDSenderGetAll(System.IAsyncResult result)
        {
            return base.Channel.EndIDSenderGetAll(result);
        }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<Beams.XamaService.IDSender> EndIDSenderGetAll(System.IAsyncResult result)
        {
            var retVal = ((Beams.XamaService.XamaWhatsAppServiceSoap)(this)).EndIDSenderGetAll(result);
            return retVal.Body.IDSenderGetAllResult;
        }
        private System.IAsyncResult OnBeginIDSenderGetAll(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return BeginIDSenderGetAll(callback, asyncState);
        }
        private object[] OnEndIDSenderGetAll(System.IAsyncResult result)
        {
            var retVal = EndIDSenderGetAll(result);
            return new object[] {
                    retVal };
        }
        private void OnIDSenderGetAllCompleted(object state)
        {
            if ((IDSenderGetAllCompleted != null))
            {
                var e = ((InvokeAsyncCompletedEventArgs)(state));
                IDSenderGetAllCompleted(this, new IDSenderGetAllCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        public void IDSenderGetAllAsync()
        {
            IDSenderGetAllAsync(null);
        }
        public void IDSenderGetAllAsync(object userState)
        {
            if ((onBeginIDSenderGetAllDelegate == null))
            {
                onBeginIDSenderGetAllDelegate = new BeginOperationDelegate(OnBeginIDSenderGetAll);
            }
            if ((onEndIDSenderGetAllDelegate == null))
            {
                onEndIDSenderGetAllDelegate = new EndOperationDelegate(OnEndIDSenderGetAll);
            }
            if ((onIDSenderGetAllCompletedDelegate == null))
            {
                onIDSenderGetAllCompletedDelegate = new System.Threading.SendOrPostCallback(OnIDSenderGetAllCompleted);
            }
            base.InvokeAsync(onBeginIDSenderGetAllDelegate, null, onEndIDSenderGetAllDelegate, onIDSenderGetAllCompletedDelegate, userState);
        }
    }
}
