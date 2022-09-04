//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemApipViewModel.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemApip file
/// </summary>
public partial class AssessmentItemApipViewModel : ObservableValidator, IAssessmentItemApip
{
    #region "AssessmentItemApipViewModel Constructor"
    /// </summary>
    /// The service provider instance.
    /// <summary>
    private System.IServiceProvider? serviceProvider;

    /// <summary>
    /// AssessmentItemApipViewModel Constructor
    /// </summary>
    public AssessmentItemApipViewModel(System.IServiceProvider provider)
    {
        serviceProvider = provider;
        OnAssessmentItemApipViewModelConstruction();
    }

    /// <summary>
    /// AssessmentItemApipViewModel Constructor partial method
    /// <para>
    /// This method is called by the view model constructor
    /// to allow the inclusion of custom processing in
    /// the view models construction
    /// </para>
    /// </summary>
    partial void OnAssessmentItemApipViewModelConstruction();
    #endregion"

    #region "Backing Fields"
    // Every viewmodel has a Title property
    private string viewTitle = "Hello from AssessmentItemApip";

    // The isNew property is set if the view model has been created but not saved to the database
    private bool isNew = false;

    /// The isDeleted property is set if the view model is to be deleted from the database
    private bool isDeleted = false;

    /// The view model is changed and needs to be save to the database.
    public bool isChanged = false;

    /// The view model is performing a long running task
    public bool isBusy = false;

    // AdaptiveIndicator -- (backing property for Assessment Item Adaptive Indicator)
    private Boolean? adaptiveIndicator;

    // ItemBodyXml -- (backing property for Assessment Item APIP Item Body XML)
    private System.String itemBodyXml;

    // ModalFeedbackXml -- (backing property for Assessment Item APIP Modal Feedback XML)
    private System.String modalFeedbackXml;

    // OutcomeDeclarationXml -- (backing property for Assessment Item APIP Outcome Declaration XML)
    private System.String outcomeDeclarationXml;

    // ResponseDeclarationXml -- (backing property for Assessment Item APIP Response Declaration XML)
    private System.String responseDeclarationXml;

    // ResponseProcessingTemplateUrl -- (backing property for Assessment Item APIP Response Processing Template URL)
    private System.String responseProcessingTemplateUrl;

    // ResponseProcessingXml -- (backing property for Assessment Item APIP Response Processing XML)
    private System.String responseProcessingXml;

    // TemplateDeclarationXml -- (backing property for Assessment Item APIP Template Declaration XML)
    private System.String templateDeclarationXml;

    // TemplateProcessingXml -- (backing property for Assessment Item APIP Template Processing XML)
    private System.String templateProcessingXml;

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

    #region "IAssessmentItemApip Properties"
    /// <summary>
    /// Assessment Item Adaptive Indicator
    /// <para>
    /// This indicator determines whether an assessment item is an adaptive item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20111">Assessment Item Adaptive Indicator</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item Adaptive Indicator")]
    public Boolean? AdaptiveIndicator { get => adaptiveIndicator; set => SetProperty(ref adaptiveIndicator, value, false); }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item APIP Item Body XML
    /// <para>
    /// The item body contains the text, graphics, media objects, and interactions that describe the item's content and information about how it is structured. The body is presented by combining it with stylesheet information, either explicitly or implicitly using the default style rules of the delivery or authoring system. This element contains the appropriate XML from the IMS Global APIP Specification defining the various item body interactions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20110">Assessment Item APIP Item Body XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Item Body XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ItemBodyXml { get => itemBodyXml; set => SetProperty(ref itemBodyXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Modal Feedback XML
    /// <para>
    /// Modal feedback is shown to the candidate directly following response processing. The value of an outcome variable is used in conjunction with the showHide and identifier attributes to determine whether or not the feedback is shown in a similar way to feedbackElement. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20109">Assessment Item APIP Modal Feedback XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Modal Feedback XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ModalFeedbackXml { get => modalFeedbackXml; set => SetProperty(ref modalFeedbackXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Outcome Declaration XML
    /// <para>
    /// Outcome variables are declared by outcome declarations. Their value is set either from a default given in the declaration itself or by a responseRule during response processing.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20106">Assessment Item APIP Outcome Declaration XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Outcome Declaration XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String OutcomeDeclarationXml { get => outcomeDeclarationXml; set => SetProperty(ref outcomeDeclarationXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Response Declaration XML
    /// <para>
    /// Response declarations state what the response variables include.  The response declaration may assign an optional correct response. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20105">Assessment Item APIP Response Declaration XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Response Declaration XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ResponseDeclarationXml { get => responseDeclarationXml; set => SetProperty(ref responseDeclarationXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Response Processing Template URL
    /// <para>
    /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20103">Assessment Item APIP Response Processing Template URL</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Response Processing Template URL")]
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ResponseProcessingTemplateUrl { get => responseProcessingTemplateUrl; set => SetProperty(ref responseProcessingTemplateUrl, value, true); }

    /// <summary>
    /// Assessment Item APIP Response Processing XML
    /// <para>
    /// Response processing is the process by which the Delivery Engine assigns outcomes based on the learner's responses. The outcomes may be used to provide feedback to the learner Feedback is either provided immediately following the end of the learner's attempt or it is provided at some later time, perhaps as part of a summary report on the item session. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20104">Assessment Item APIP Response Processing XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Response Processing XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String ResponseProcessingXml { get => responseProcessingXml; set => SetProperty(ref responseProcessingXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Template Declaration XML
    /// <para>
    /// Template declarations declare item variables that are to be used specifically for the purposes of cloning items. They can have their value set only during template processing. They are referred to within the item body in order to individualize the clone and possibly also within the response Processing rules if the cloning process affects the way the item is scored.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20107">Assessment Item APIP Template Declaration XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Template Declaration XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String TemplateDeclarationXml { get => templateDeclarationXml; set => SetProperty(ref templateDeclarationXml, value, true); }

    /// <summary>
    /// Assessment Item APIP Template Processing XML
    /// <para>
    /// Template processing consists of one or more template rules that are followed by the cloning engine or delivery system in order to assign values to the template variables. Template processing is identical in form to responseProcessing except that the purpose is to assign values to template variables, not outcome variables. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20108">Assessment Item APIP Template Processing XML</a>
    /// </para>
    /// </summary>
    [DisplayName("Assessment Item APIP Template Processing XML")]
    [Required(ErrorMessage="{0} is required.")]
    public System.String TemplateProcessingXml { get => templateProcessingXml; set => SetProperty(ref templateProcessingXml, value, true); }

    #endregion

    /// <summary>
    /// Load the viewmodel from a model
    /// </summary>
    public void Load(IAssessmentItemApip model)
    {
        IsBusy = true;
        Id = model.Id;
        AdaptiveIndicator = model.AdaptiveIndicator; // Assessment Item Adaptive Indicator
        AssessmentItemId = model.AssessmentItemId; // 
        ItemBodyXml = model.ItemBodyXml; // Assessment Item APIP Item Body XML
        ModalFeedbackXml = model.ModalFeedbackXml; // Assessment Item APIP Modal Feedback XML
        OutcomeDeclarationXml = model.OutcomeDeclarationXml; // Assessment Item APIP Outcome Declaration XML
        ResponseDeclarationXml = model.ResponseDeclarationXml; // Assessment Item APIP Response Declaration XML
        ResponseProcessingTemplateUrl = model.ResponseProcessingTemplateUrl; // Assessment Item APIP Response Processing Template URL
        ResponseProcessingXml = model.ResponseProcessingXml; // Assessment Item APIP Response Processing XML
        TemplateDeclarationXml = model.TemplateDeclarationXml; // Assessment Item APIP Template Declaration XML
        TemplateProcessingXml = model.TemplateProcessingXml; // Assessment Item APIP Template Processing XML
        IsChanged = false;
        IsNew = false;
        IsBusy = false;
    }
}
