using System.Text.Json.Serialization;

namespace DistrictEnterpriseStatisticalData.Dto.DTO;

/// <summary>
///     DTO для создания формы собственности
/// </summary>
public class FormOfOwnershipCreateDto
{
    /// <summary>
    ///     Форма собственности
    /// </summary>
    [JsonPropertyName("form")]
    public required string Form { get; set; }
}