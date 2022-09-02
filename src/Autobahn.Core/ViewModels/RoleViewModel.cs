//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   RoleViewModel.cs
//***************************************************************************

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Autobahn.Education.Common.ViewModels
{
     /// <summary>
     /// The Role View Model
     /// </summary>
    public partial class RoleViewModel : ObservableValidator, IRole
    {
        #region "RoleViewModel Constructor"
        /// </summary>
        /// The service provider instance.
        /// <summary>
        private System.IServiceProvider? serviceProvider;

        /// <summary>
        /// RoleViewModel Constructor
        /// </summary>
        public RoleViewModel(System.IServiceProvider provider)
        {
            serviceProvider = provider;
            OnRoleViewModelConstruction();
        }

        /// <summary>
        /// RoleViewModel Constructor partial method
        /// <para>
        /// This method is called by the view model constructor
        /// to allow the inclusion of custom processing in
        /// the view models construction
        /// </para>
        /// </summary>
        partial void OnRoleViewModelConstruction();
        #endregion"

        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string viewTitle = "Hello from Role";

        // The isNew property is set if the view model has been created but not saved to the database
        private bool isNew = false;

        /// The isDeleted property is set if the view model is to be deleted from the database
        private bool isDeleted = false;

        /// The view model is changed and needs to be save to the database.
        public bool isChanged = false;

        /// The view model is performing a long running task
        public bool isBusy = false;

        // member variable for the Name property
        private System.String name;

        #endregion

        #region "IAutobahnBase Properties"
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => viewTitle; set => SetProperty(ref viewTitle, value, false); }

        /// <summary>
        /// The IsNew property is set if the view model has been created but not saved to the database
        /// </summary>
        public bool IsNew { get => isNew; set => SetProperty(ref isNew, value, false); }

        /// <summary>
        /// The IsDeleted property is set if the view model is to be delted from the database
        /// </summary>
        public bool IsDeleted { get => isDeleted; set => SetProperty(ref isDeleted, value, false); }

        /// <summary>
        /// The primary key of the view model
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// The view model is changed and needs to be save to the database.
        /// </summary>
        public bool IsChanged { get => isChanged; private set => SetProperty(ref isChanged, value, false); }

        /// <summary>
        /// The view model is performing a long running task
        /// </summary>
        public bool IsBusy { get => isBusy; private set => SetProperty(ref isBusy, value, false); }

        /// <summary>
        /// The view model's changes have been save so update its tracking properties
        /// </summary>
        public void AcceptChanges()
        {
            IsNew = false;
            IsChanged = false;
        }
        #endregion

        #region "IRole Properties"
        /// <summary>
        /// A description of the way in which a person relates to an organization.
        /// </summary>
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(50,ErrorMessage="The {0} must be less then {1} characters.")]
        [DisplayName("Role")]
        public System.String Name { get => name; set => SetProperty(ref name, value, true); }

        /// <summary>
        /// Role Type
        /// <para>
        /// A description of the way in which a person relates to an organization.
        /// </para>
        /// </summary>
        public Guid? RefRoleId { get; set; }
        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRole model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // 
            RefRoleId = model.RefRoleId; // Role
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
