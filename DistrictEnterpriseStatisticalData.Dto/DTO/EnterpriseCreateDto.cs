using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DistrictEnterpriseStatisticalData.Dto.DTO;

/// <summary>
///     DTO для создания предприятия
/// </summary>
public class EnterpriseCreateDto
{
    /// <summary>
    ///     Тип отрасли
    /// </summary>
    [JsonPropertyName("enterprise_type_id")]
    [Required(ErrorMessage = "Не введен идентификатор типа предприятия")]
    public required int EnterpriseTypeId { get; set; }

    /// <summary>
    ///     Наименование
    /// </summary>
    [JsonPropertyName("name")]
    [Required(ErrorMessage = "Не введено название предприятия")]

    public required string Name { get; set; }

    /// <summary>
    ///     Адрес
    /// </summary>
    [JsonPropertyName("address")]
    [Required(ErrorMessage = "Не введен адрес предприятия")]
    public required string Address { get; set; }

    /// <summary>
    ///     Телефон
    /// </summary>
    [JsonPropertyName("phone_number")]
    [Required(ErrorMessage = "Не введен телефонный номер предприятия")]
    public required string PhoneNumber { get; set; }

    /// <summary>
    ///     Форма собственности
    /// </summary>
    [JsonPropertyName("form_of_ownership_id")]
    [Required(ErrorMessage = "Не введен идентификатор формы собственности")]
    public required int FormId { get; set; }

    /// <summary>
    ///     Количество работающих
    /// </summary>
    [JsonPropertyName("employees_number")]
    [Required(ErrorMessage = "Не введено количество сотрудников")]
    public required int EmployeesNumber { get; set; }

    /// <summary>
    ///     Общая площадь
    /// </summary>
    [JsonPropertyName("total_area")]
    [Required(ErrorMessage = "Не введена общая площадь")]
    public required int TotalArea { get; set; }
}