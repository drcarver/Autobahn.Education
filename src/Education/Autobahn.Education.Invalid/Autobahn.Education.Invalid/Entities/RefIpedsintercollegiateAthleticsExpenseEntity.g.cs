//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefIpedsintercollegiateAthleticsExpenseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIpedsintercollegiateAthleticsExpense file
/// </summary>
[Table("RefIpedsintercollegiateAthleticsExpense", Schema = "Invalid")]
public partial class RefIpedsintercollegiateAthleticsExpenseEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIpedsintercollegiateAthleticsExpense Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIpedsintercollegiateAthleticsExpenses"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefIpedsintercollegiateAthleticsExpenses")]
    public Guid RefIpedsintercollegiateAthleticsExpensesId { get; set; }

    #endregion
}
