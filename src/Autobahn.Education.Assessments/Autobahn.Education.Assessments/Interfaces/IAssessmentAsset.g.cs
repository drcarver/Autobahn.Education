//***************************************************************************
//* DomainName: Assessments
//* FileName:   IAssessmentAsset.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAsset file
/// </summary>
public partial interface IAssessmentAsset
{
    #region "IAssessmentAsset Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Assessment Asset Content Mime Type
    /// <para>
    /// MIME type to specifically indicate the Assessment Asset content type.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20154">Assessment Asset Content Mime Type</a>
    /// </para>
    /// </summary>
    System.String ContentMimeType { get; set; }

    /// <summary>
    /// Assessment Asset Content URL
    /// <para>
    /// The Uniform Resource Locator (URL) location of the external Assessment Asset content.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20155">Assessment Asset Content URL</a>
    /// </para>
    /// </summary>
    System.String ContentUrl { get; set; }

    System.String ContentXml { get; set; }

    /// <summary>
    /// Assessment Asset Identifier
    /// <para>
    /// A unique code identifying the Assessment Asset provided by the authoring system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20149">Assessment Asset Identifier</a>
    /// </para>
    /// </summary>
    System.String Identifier { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    Guid? LearningResourceId { get; set; }

    /// <summary>
    /// Assessment Asset Name
    /// <para>
    /// The name of the Assessment Asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20151">Assessment Asset Name</a>
    /// </para>
    /// </summary>
    System.String Name { get; set; }

    /// <summary>
    /// Assessment Asset Owner
    /// <para>
    /// The name of the ownership rights holder or publisher of the asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20152">Assessment Asset Owner</a>
    /// </para>
    /// </summary>
    System.String Owner { get; set; }

    /// <summary>
    /// Assessment Asset Published Date
    /// <para>
    /// The date that this version of the asset was made available for use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20148">Assessment Asset Published Date</a>
    /// </para>
    /// </summary>
    DateTime? PublishedDate { get; set; }

    /// <summary>
    /// Assessment Asset Identifier Type
    /// <para>
    /// The type of identifier that is provided for this asset.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20150">Assessment Asset Identifier Type</a>
    /// </para>
    /// </summary>
    Int32? RefAssessmentAssestIdentifierType { get; set; }

    /// <summary>
    /// Assessment Asset Type
    /// <para>
    /// Specifies a predominant type of assessment asset represented by the Learning Resource.  Assessment assets represent any content used to compose an assessment item, is referenced by an item but not part of the item content itself, or is content that is included as part of a section within an assessment form. Assets can be static content such as art work or dynamic assets such as calculators.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20147">Assessment Asset Type</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentAssetTypeId { get; set; }

    /// <summary>
    /// Assessment Language
    /// <para>
    /// The language in which the assessment form is designed to be delivered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20073">Assessment Language</a>
    /// </para>
    /// </summary>
    Guid? RefAssessmentLanguageId { get; set; }

    /// <summary>
    /// Assessment Asset Version
    /// <para>
    /// A version number or label defined by the publisher.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20146">Assessment Asset Version</a>
    /// </para>
    /// </summary>
    System.String Version { get; set; }

    #endregion
}
