//**********************************************************
//* DomainName: Autobahn.Core
//* FileName:   OrganizationViewModel.cs
//***************************************************************************

using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// An organization, is an entity—such as a company, an 
/// institution, or an association—comprising one or 
/// more people and having a particular purpose.
/// </summary>
[ObservableRecipient]
public partial class OrganizationViewModel : ObservableValidator, IOrganization 
{ 
    #region "OrganizationViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider serviceProvider;

    /// <summary>
    /// OrganizationDetailViewModel Constructor
    /// </summary>
    public OrganizationViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnOrganizationDetailViewModelConstruction();
    }

    /// <summary>
    /// OrganizationDetailViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnOrganizationDetailViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from Organization";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // ShortName -- (backing property for Short Name of Institution)
    private System.String shortName;
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

    #region "IOrganization Properties"
    /// <summary>
    /// Short Name of Institution
    /// <para>
    /// The name of the institution, which may be the abbreviated form of the full legally accepted name.
    /// </para>
    /// </summary>
    [DisplayName("Short Name of Institution")]
    [Required(ErrorMessage = "{0} is required.")]
    [StringLength(30, ErrorMessage = "The {0} must be less then {1} characters.")]
    public System.String ShortName { get => shortName; set => SetProperty(ref shortName, value, true); }
    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IOrganization model)
    {
        IsBusy = true;
        Id = model.Id;
        ShortName = model.ShortName; // Short Name of Institution
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
