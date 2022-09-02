//***************************************************************************
//* DomainName: Common Models
//* FileName:   ServiceFrequencyViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IServiceFrequency file
/// </summary>
public partial class ServiceFrequencyViewModel : ObservableValidator, IServiceFrequency
{
    #region "ServiceFrequencyViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// ServiceFrequencyViewModel Constructor
    /// </summary>
    public ServiceFrequencyViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnServiceFrequencyViewModelConstruction();
    }

    /// <summary>
    /// ServiceFrequencyViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnServiceFrequencyViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from ServiceFrequency";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // DurationInMinutes -- (backing property for Duration Length in Minutes)
    private Int32? durationInMinutes;

    // FrequencyLength -- (backing property for Frequency Length)
    private Int32? frequencyLength;

    // InstancesPerCycle -- (backing property for Frequency Instances Per Cycle)
    private Int32? instancesPerCycle;

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

    #region "IServiceFrequency Properties"
    /// <summary>
    /// Duration Length in Minutes
    /// <para>
    /// The number of minutes in an instance.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20697">Duration Length in Minutes</a>
    /// </para>
    /// </summary>
    [DisplayName("Duration Length in Minutes")]
    public Int32? DurationInMinutes { get => durationInMinutes; set => SetProperty(ref durationInMinutes, value, false); }

    /// <summary>
    /// Frequency Length
    /// <para>
    /// The number of units within a repeating cycle. Used with Frequency and Frequency Units elements to describe the occurrence of repeating events such as student services delivered 3 times a week for 16 weeks.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20696">Frequency Length</a>
    /// </para>
    /// </summary>
    [DisplayName("Frequency Length")]
    public Int32? FrequencyLength { get => frequencyLength; set => SetProperty(ref frequencyLength, value, false); }

    /// <summary>
    /// Frequency Instances Per Cycle
    /// <para>
    /// The number of recurrences within a cycle.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20695">Frequency Instances Per Cycle</a>
    /// </para>
    /// </summary>
    [DisplayName("Frequency Instances Per Cycle")]
    public Int32? InstancesPerCycle { get => instancesPerCycle; set => SetProperty(ref instancesPerCycle, value, false); }

    /// <summary>
    /// Frequency Unit
    /// <para>
    /// The unit of time by which a cycle is defined.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20694">Frequency Unit</a>
    /// </para>
    /// </summary>
    [DisplayName("Frequency Unit")]
    public Guid? RefFrequencyUnitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IServicePlan"/> model
    /// </summary>
    public Guid ServicePlanId { get; set; }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IServiceFrequency model)
    {
        IsBusy = true;
        Id = model.Id;
        DurationInMinutes = model.DurationInMinutes; // Duration Length in Minutes
        FrequencyLength = model.FrequencyLength; // Frequency Length
        InstancesPerCycle = model.InstancesPerCycle; // Frequency Instances Per Cycle
        RefFrequencyUnitId = model.RefFrequencyUnitId; // Frequency Unit
        ServicePlanId = model.ServicePlanId; // 
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
