using System;
using Mallify.API.Models;

namespace Mallify.API.Services.Communication
{
    public class SaveCategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private SaveCategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        public SaveCategoryResponse(Category category) : this(true, string.Empty, category) { }

        public SaveCategoryResponse(string message) : this(false, message, null) { }
    }
}
