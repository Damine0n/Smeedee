//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 09.08.2010 20:18:04
namespace Smeedee.Client.Framework.SL.RESTService
{
    
    /// <summary>
    /// There are no comments for SmeedeeREST in the schema.
    /// </summary>
    public partial class SmeedeeREST : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SmeedeeREST object.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public SmeedeeREST(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("Smeedee.Client.Web.Services.DTO.SourceControl", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Smeedee.Client.Framework.SL.RESTService", typeName.Substring(45)), false);
            }
            if (typeName.StartsWith("Smeedee.Client.Web.Services.DTO.NoSql", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("Smeedee.Client.Framework.SL.RESTService.Smeedee.Client.Web.Services.DTO.NoSql", typeName.Substring(37)), false);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Smeedee.Client.Framework.SL.RESTService.Smeedee.Client.Web.Services.DTO.NoSql", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Smeedee.Client.Web.Services.DTO.NoSql.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Smeedee.Client.Framework.SL.RESTService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("Smeedee.Client.Web.Services.DTO.SourceControl.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Changesets in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<ChangesetDTO> Changesets
        {
            get
            {
                if ((this._Changesets == null))
                {
                    this._Changesets = base.CreateQuery<ChangesetDTO>("Changesets");
                }
                return this._Changesets;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<ChangesetDTO> _Changesets;
        /// <summary>
        /// There are no comments for NoSqlDatabases in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDatabaseDTO> NoSqlDatabases
        {
            get
            {
                if ((this._NoSqlDatabases == null))
                {
                    this._NoSqlDatabases = base.CreateQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDatabaseDTO>("NoSqlDatabases");
                }
                return this._NoSqlDatabases;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDatabaseDTO> _NoSqlDatabases;
        /// <summary>
        /// There are no comments for NoSqlCollections in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlCollectionDTO> NoSqlCollections
        {
            get
            {
                if ((this._NoSqlCollections == null))
                {
                    this._NoSqlCollections = base.CreateQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlCollectionDTO>("NoSqlCollections");
                }
                return this._NoSqlCollections;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlCollectionDTO> _NoSqlCollections;
        /// <summary>
        /// There are no comments for NoSqlDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDocumentDTO> NoSqlDocuments
        {
            get
            {
                if ((this._NoSqlDocuments == null))
                {
                    this._NoSqlDocuments = base.CreateQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDocumentDTO>("NoSqlDocuments");
                }
                return this._NoSqlDocuments;
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDocumentDTO> _NoSqlDocuments;
        /// <summary>
        /// There are no comments for Changesets in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToChangesets(ChangesetDTO changesetDTO)
        {
            base.AddObject("Changesets", changesetDTO);
        }
        /// <summary>
        /// There are no comments for NoSqlDatabases in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNoSqlDatabases(RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDatabaseDTO noSqlDatabaseDTO)
        {
            base.AddObject("NoSqlDatabases", noSqlDatabaseDTO);
        }
        /// <summary>
        /// There are no comments for NoSqlCollections in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNoSqlCollections(RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlCollectionDTO noSqlCollectionDTO)
        {
            base.AddObject("NoSqlCollections", noSqlCollectionDTO);
        }
        /// <summary>
        /// There are no comments for NoSqlDocuments in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNoSqlDocuments(RESTService.Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDocumentDTO noSqlDocumentDTO)
        {
            base.AddObject("NoSqlDocuments", noSqlDocumentDTO);
        }
    }
    /// <summary>
    /// There are no comments for ComplexType Smeedee.Client.Web.Services.DTO.SourceControl.AuthorDTO in the schema.
    /// </summary>
    public partial class AuthorDTO : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Username in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                this.OnUsernameChanging(value);
                this._Username = value;
                this.OnUsernameChanged();
                this.OnPropertyChanged("Username");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Username;
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Smeedee.Client.Web.Services.DTO.SourceControl.ChangesetDTO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Revision
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Changesets")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Revision")]
    public partial class ChangesetDTO : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ChangesetDTO object.
        /// </summary>
        /// <param name="revision">Initial value of Revision.</param>
        /// <param name="author">Initial value of Author.</param>
        /// <param name="time">Initial value of Time.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static ChangesetDTO CreateChangesetDTO(string revision, AuthorDTO author, global::System.DateTime time)
        {
            ChangesetDTO changesetDTO = new ChangesetDTO();
            changesetDTO.Revision = revision;
            if ((author == null))
            {
                throw new global::System.ArgumentNullException("author");
            }
            changesetDTO.Author = author;
            changesetDTO.Time = time;
            return changesetDTO;
        }
        /// <summary>
        /// There are no comments for Property Revision in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Revision
        {
            get
            {
                return this._Revision;
            }
            set
            {
                this.OnRevisionChanging(value);
                this._Revision = value;
                this.OnRevisionChanged();
                this.OnPropertyChanged("Revision");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Revision;
        partial void OnRevisionChanging(string value);
        partial void OnRevisionChanged();
        /// <summary>
        /// There are no comments for Property Author in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public AuthorDTO Author
        {
            get
            {
                if (((this._Author == null) 
                            && (this._AuthorInitialized != true)))
                {
                    this._Author = new AuthorDTO();
                    this._AuthorInitialized = true;
                }
                return this._Author;
            }
            set
            {
                this.OnAuthorChanging(value);
                this._Author = value;
                this._AuthorInitialized = true;
                this.OnAuthorChanged();
                this.OnPropertyChanged("Author");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private AuthorDTO _Author;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _AuthorInitialized;
        partial void OnAuthorChanging(AuthorDTO value);
        partial void OnAuthorChanged();
        /// <summary>
        /// There are no comments for Property Time in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.DateTime Time
        {
            get
            {
                return this._Time;
            }
            set
            {
                this.OnTimeChanging(value);
                this._Time = value;
                this.OnTimeChanged();
                this.OnPropertyChanged("Time");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.DateTime _Time;
        partial void OnTimeChanging(global::System.DateTime value);
        partial void OnTimeChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
// Original file name:
// Generation date: 09.08.2010 20:18:04
namespace Smeedee.Client.Framework.SL.RESTService.Smeedee.Client.Web.Services.DTO.NoSql
{
    
    /// <summary>
    /// There are no comments for Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDatabaseDTO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("NoSqlDatabases")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Name")]
    public partial class NoSqlDatabaseDTO : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NoSqlDatabaseDTO object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static NoSqlDatabaseDTO CreateNoSqlDatabaseDTO(string name)
        {
            NoSqlDatabaseDTO noSqlDatabaseDTO = new NoSqlDatabaseDTO();
            noSqlDatabaseDTO.Name = name;
            return noSqlDatabaseDTO;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Collections in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<NoSqlCollectionDTO> Collections
        {
            get
            {
                return this._Collections;
            }
            set
            {
                this._Collections = value;
                this.OnPropertyChanged("Collections");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<NoSqlCollectionDTO> _Collections = new global::System.Data.Services.Client.DataServiceCollection<NoSqlCollectionDTO>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Smeedee.Client.Web.Services.DTO.NoSql.NoSqlCollectionDTO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("NoSqlCollections")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Name")]
    public partial class NoSqlCollectionDTO : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NoSqlCollectionDTO object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static NoSqlCollectionDTO CreateNoSqlCollectionDTO(string name)
        {
            NoSqlCollectionDTO noSqlCollectionDTO = new NoSqlCollectionDTO();
            noSqlCollectionDTO.Name = name;
            return noSqlCollectionDTO;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Database in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NoSqlDatabaseDTO Database
        {
            get
            {
                return this._Database;
            }
            set
            {
                this._Database = value;
                this.OnPropertyChanged("Database");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private NoSqlDatabaseDTO _Database;
        /// <summary>
        /// There are no comments for Documents in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<NoSqlDocumentDTO> Documents
        {
            get
            {
                return this._Documents;
            }
            set
            {
                this._Documents = value;
                this.OnPropertyChanged("Documents");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<NoSqlDocumentDTO> _Documents = new global::System.Data.Services.Client.DataServiceCollection<NoSqlDocumentDTO>(null, System.Data.Services.Client.TrackingMode.None);
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for Smeedee.Client.Web.Services.DTO.NoSql.NoSqlDocumentDTO in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("NoSqlDocuments")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class NoSqlDocumentDTO : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new NoSqlDocumentDTO object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static NoSqlDocumentDTO CreateNoSqlDocumentDTO(global::System.Guid ID)
        {
            NoSqlDocumentDTO noSqlDocumentDTO = new NoSqlDocumentDTO();
            noSqlDocumentDTO.Id = ID;
            return noSqlDocumentDTO;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Guid Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property JSON in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string JSON
        {
            get
            {
                return this._JSON;
            }
            set
            {
                this.OnJSONChanging(value);
                this._JSON = value;
                this.OnJSONChanged();
                this.OnPropertyChanged("JSON");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _JSON;
        partial void OnJSONChanging(string value);
        partial void OnJSONChanged();
        /// <summary>
        /// There are no comments for Collection in the schema.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NoSqlCollectionDTO Collection
        {
            get
            {
                return this._Collection;
            }
            set
            {
                this._Collection = value;
                this.OnPropertyChanged("Collection");
            }
        }
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private NoSqlCollectionDTO _Collection;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
