using System;

namespace Entities.Abstract
{
    public interface ICreated
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set;}

    }
}
