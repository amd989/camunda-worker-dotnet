// Copyright (c) Alexey Malinin. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;
using Microsoft.Extensions.DependencyInjection;

namespace Camunda.Worker
{
    public class CamundaWorkerBuilder : ICamundaWorkerBuilder
    {
        public CamundaWorkerBuilder(IServiceCollection services)
        {
            Services = services;
        }

        public IServiceCollection Services { get; }

        public ICamundaWorkerBuilder Add(HandlerDescriptor descriptor)
        {
            if (descriptor == null)
            {
                throw new ArgumentNullException(nameof(descriptor));
            }

            Services.AddSingleton(descriptor);
            return this;
        }
    }
}
