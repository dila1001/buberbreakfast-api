using ErrorOr;

namespace BuberBreakfast.Api.ServiceErrors;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName =>
            Error.Validation(
                code: "Breakfast.InValidName",
                description: $"Breakfast name should be between {Models.Breakfast.MinNameLength}-{Models.Breakfast.MaxNameLength} charaters long."
            );
        public static Error InvalidDescription =>
            Error.Validation(
                code: "Breakfast.InValidDescription",
                description: $"Description should be between {Models.Breakfast.MinDescriptionLength}-{Models.Breakfast.MaxDescriptionLength} charaters long."
            );
        public static Error NotFound =>
            Error.NotFound(code: "Breakfast.NotFound", description: "Breakfast not found");
    }
}
