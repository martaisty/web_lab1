﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
