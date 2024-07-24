using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Application.Features.Commands.UpdateProduct
{
    public class UpdateProductCommandValidator: AbstractValidator<UpdateProductCommandRequest>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("Id is required");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required")
                .MaximumLength(50).WithMessage("Title must not exceed 50 characters");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(200).WithMessage("Description must not exceed 200 characters");

            RuleFor(x => x.BrandId)
                .GreaterThan(0).WithMessage("Brand is required");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price is required");

            RuleFor(x => x.Discount)
                .GreaterThanOrEqualTo(0).WithMessage("Discount must be greater than or equal to 0")
                .LessThanOrEqualTo(100).WithMessage("Discount must be less than or equal to 100");

            RuleFor(x => x.CategoryIds)
                .NotEmpty()
                .Must(categories => categories.Any()).WithMessage("At least one category is required")
                .WithName("Categories");
        }
    }
}
