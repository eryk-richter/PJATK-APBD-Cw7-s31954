namespace Cw7.DTOs;

public record PcComponentsDto(
    int PcId,
    Dictionary<ComponentDto, int> Components
    );