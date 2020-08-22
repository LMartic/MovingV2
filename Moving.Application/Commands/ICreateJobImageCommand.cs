﻿using Moving.Application;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Commands
{
    public interface ICreateJobImageCommand : ICommand<JobImageDto>
    {
    }
}
