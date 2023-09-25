﻿namespace AspectCore.Abstractions.Internal.Test.Fakes
{
    public class InstanceSupportOriginalService: InstanceServiceProvider, IRealServiceProvider
    {
        public InstanceSupportOriginalService(object instance) : base(instance)
        {
        }

        public void Dispose()
        {
        }
    }
}
