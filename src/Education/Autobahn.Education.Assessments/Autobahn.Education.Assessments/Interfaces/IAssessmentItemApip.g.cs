//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentItemApip.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemApip file
/// </summary>
public partial interface IAssessmentItemApip
{
    #region "IAssessmentItemApip Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Item Adaptive Indicator
    /// <para>
    /// This indicator determines whether an assessment item is an adaptive item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20111">Assessment Item Adaptive Indicator</a>
    /// </para>
    /// </summary>
    Boolean? AdaptiveIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item APIP Item Body XML
    /// <para>
    /// The item body contains the text, graphics, media objects, and interactions that describe the item's content and information about how it is structured. The body is presented by combining it with stylesheet information, either explicitly or implicitly using the default style rules of the delivery or authoring system. This element contains the appropriate XML from the IMS Global APIP Specification defining the various item body interactions.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20110">Assessment Item APIP Item Body XML</a>
    /// </para>
    /// </summary>
    System.String ItemBodyXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Modal Feedback XML
    /// <para>
    /// Modal feedback is shown to the candidate directly following response processing. The value of an outcome variable is used in conjunction with the showHide and identifier attributes to determine whether or not the feedback is shown in a similar way to feedbackElement. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20109">Assessment Item APIP Modal Feedback XML</a>
    /// </para>
    /// </summary>
    System.String ModalFeedbackXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Outcome Declaration XML
    /// <para>
    /// Outcome variables are declared by outcome declarations. Their value is set either from a default given in the declaration itself or by a responseRule during response processing.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20106">Assessment Item APIP Outcome Declaration XML</a>
    /// </para>
    /// </summary>
    System.String OutcomeDeclarationXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Response Declaration XML
    /// <para>
    /// Response declarations state what the response variables include.  The response declaration may assign an optional correct response. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20105">Assessment Item APIP Response Declaration XML</a>
    /// </para>
    /// </summary>
    System.String ResponseDeclarationXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Response Processing Template URL
    /// <para>
    /// These templates are described using the processing language defined in IMS Global APIP specification and are distributed (in XML form) along with it. Delivery engines that support generalized response processing do not need to implement special mechanisms to support them as a template file can be parsed directly while processing the assessment item that refers to it. This element provides the URL for the template.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20103">Assessment Item APIP Response Processing Template URL</a>
    /// </para>
    /// </summary>
    System.String ResponseProcessingTemplateUrl { get; set; }

    /// <summary>
    /// Assessment Item APIP Response Processing XML
    /// <para>
    /// Response processing is the process by which the Delivery Engine assigns outcomes based on the learner's responses. The outcomes may be used to provide feedback to the learner Feedback is either provided immediately following the end of the learner's attempt or it is provided at some later time, perhaps as part of a summary report on the item session. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20104">Assessment Item APIP Response Processing XML</a>
    /// </para>
    /// </summary>
    System.String ResponseProcessingXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Template Declaration XML
    /// <para>
    /// Template declarations declare item variables that are to be used specifically for the purposes of cloning items. They can have their value set only during template processing. They are referred to within the item body in order to individualize the clone and possibly also within the response Processing rules if the cloning process affects the way the item is scored.  The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20107">Assessment Item APIP Template Declaration XML</a>
    /// </para>
    /// </summary>
    System.String TemplateDeclarationXml { get; set; }

    /// <summary>
    /// Assessment Item APIP Template Processing XML
    /// <para>
    /// Template processing consists of one or more template rules that are followed by the cloning engine or delivery system in order to assign values to the template variables. Template processing is identical in form to responseProcessing except that the purpose is to assign values to template variables, not outcome variables. The XML from the IMS Global APIP Specification would be included.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20108">Assessment Item APIP Template Processing XML</a>
    /// </para>
    /// </summary>
    System.String TemplateProcessingXml { get; set; }

    #endregion
}
