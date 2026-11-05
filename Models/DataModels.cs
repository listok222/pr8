namespace CarConfigurator.Models
{
    /// <summary>
    /// Модель автомобиля с базовой ценой.
    /// </summary>
    public class CarModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal BasePrice { get; set; }

        // Для отображения в ComboBox: "Название — 2 000 000 ₽"
        public string DisplayName => $"{Name} — {BasePrice:N0} ₽";

        public override string ToString() => DisplayName;
    }

    /// <summary>
    /// Тип двигателя с доплатой.
    /// </summary>
    public class EngineType
    {
        public string Name { get; set; } = string.Empty;
        public decimal Surcharge { get; set; }

        public string DisplayName => Surcharge == 0
            ? $"{Name} (без доплаты)"
            : $"{Name} (+{Surcharge:N0} ₽)";

        public override string ToString() => DisplayName;
    }

    /// <summary>
    /// Цвет кузова с доплатой.
    /// </summary>
    public class BodyColor
    {
        public string Name { get; set; } = string.Empty;
        public decimal Surcharge { get; set; }
        public string HexCode { get; set; } = "#FFFFFF"; // для визуализации цвета

        public string DisplayName => Surcharge == 0
            ? $"{Name} (без доплаты)"
            : $"{Name} (+{Surcharge:N0} ₽)";

        public override string ToString() => DisplayName;
    }

    /// <summary>
    /// Дополнительная опция с доплатой.
    /// </summary>
    public class Option
    {
        public string Name { get; set; } = string.Empty;
        public decimal Surcharge { get; set; }
        public bool IsSelected { get; set; }

        public string DisplayName => $"{Name} (+{Surcharge:N0} ₽)";

        public override string ToString() => DisplayName;
    }
}
