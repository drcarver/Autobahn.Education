//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIiiprofessionalDevelopmentViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIiiprofessionalDevelopment file
/// </summary>
public partial class K12leaTitleIiiprofessionalDevelopmentViewModel : ObservableValidator, IK12leaTitleIiiprofessionalDevelopment
{
    #region "K12leaTitleIiiprofessionalDevelopmentViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// K12leaTitleIiiprofessionalDevelopmentViewModel Constructor
    /// </summary>
    public K12leaTitleIiiprofessionalDevelopmentViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnK12leaTitleIiiprofessionalDevelopmentViewModelConstruction();
    }

    /// <summary>
    /// K12leaTitleIiiprofessionalDevelopmentViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnK12leaTitleIiiprofessionalDevelopmentViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from K12leaTitleIiiprofessionalDevelopment";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

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

    #region "IK12leaTitleIiiprofessionalDevelopment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
    /// </summary>
    public Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
    /// </summary>
    public Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IK12leaTitleIiiprofessionalDevelopment model)
    {
        IsBusy = true;
        Id = model.Id;
        K12leaId = model.K12leaId; // 
        K12leatitleIiiprofessionalDevelopmentId = model.K12leatitleIiiprofessionalDevelopmentId; // 
        RefTitleIiiprofessionalDevelopmentTypeId = model.RefTitleIiiprofessionalDevelopmentTypeId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
