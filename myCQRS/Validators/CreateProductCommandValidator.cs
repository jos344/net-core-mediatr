using System;
using FluentValidation;
using myCQRS.Commands;

namespace myCQRS.Validators
{
	public class CreateProductCommandValidator : AbstractValidator<AddProductCommand>
	{
		public CreateProductCommandValidator()
		{
			RuleFor(c => c.Product.Name).NotEmpty();
		}
	}
}