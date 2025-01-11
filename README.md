# Party Age Calculator

C# console application for age-based party planning and attendance management.

## Features
- Age validation
- Party category assignment
- Guest list management
- Age group statistics

## Implementation
```csharp
public class PartyCalculator
{
    public string DeterminePartyCategory(int age)
    {
        return age switch
        {
            < 13 => "Kids Party",
            < 18 => "Teen Party",
            < 21 => "Young Adult Party",
            _ => "Adult Party"
        };
    }
    
    public bool ValidateAttendance(int age, string partyType)
    {
        // Age validation logic
    }
}
```

## Structure
```
PartyAgeCalculator/
├── Program.cs
├── PartyCalculator.cs
└── Models/
    └── Guest.cs
```

## Usage
```bash
dotnet run
```

## Features
- Age-based party categorization
- Attendee validation
- Guest list management
- Age distribution reports

## License
MIT License
