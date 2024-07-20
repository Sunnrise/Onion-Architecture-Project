using OnionAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail(string title, string description, int categoryId, Category category)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
            Category = category;
        }

        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
