﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CommandPattern
{
    public interface ICommandHandler<T> where T : ICommand
    {
        Task Handle(T command);
    }
}
