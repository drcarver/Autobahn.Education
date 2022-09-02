//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefProgramTypeEntity.g.cs
//* Name:       Program Type
//* Definition: The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
//***************************************************************************

/// <summary>
/// Program Type <see cref="RefProgramType"/>
/// <para>
/// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
/// </para>
/// <para>
/// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
/// </para>
/// </summary>
[Table("RefProgramType", Schema = "Common")]
[Comment("The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.")]
public partial class RefProgramTypeEntity : ReferenceBaseEntity, IReferenceBase
{
}
