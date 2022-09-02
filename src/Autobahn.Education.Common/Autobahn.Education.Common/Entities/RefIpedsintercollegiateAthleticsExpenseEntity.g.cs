//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIpedsintercollegiateAthleticsExpenseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIpedsintercollegiateAthleticsExpense file
/// </summary>
[Table("RefIpedsintercollegiateAthleticsExpense", Schema = "Common")]
public partial class RefIpedsintercollegiateAthleticsExpenseEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIpedsintercollegiateAthleticsExpense Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefIpedsintercollegiateAthleticsExpenses property is obsolete and will be removed in a later version")]
    [ForeignKey("RefIpedsintercollegiateAthleticsExpenses")]
    public Guid RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    #endregion
}
