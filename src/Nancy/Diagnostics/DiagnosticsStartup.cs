﻿namespace Nancy.Diagnostics
{
    using System.Collections.Generic;

    using Nancy.Bootstrapper;
    using Nancy.ModelBinding;

    public class DiagnosticsStartup : IStartup
    {
        /// <summary>
        /// Gets the type registrations to register for this startup task`
        /// </summary>
        public IEnumerable<TypeRegistration> TypeRegistrations
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the collection registrations to register for this startup task
        /// </summary>
        public IEnumerable<CollectionTypeRegistration> CollectionTypeRegistrations
        {
            get { return null; }
        }

        /// <summary>
        /// Gets the instance registrations to register for this startup task
        /// </summary>
        public IEnumerable<InstanceRegistration> InstanceRegistrations
        {
            get { return null; }
        }

        /// <summary>
        /// Perform any initialisation tasks
        /// </summary>
        /// <param name="pipelines">Application pipelines</param>
        public void Initialize(IPipelines pipelines)
        {
            DiagnosticsHook.Enable(pipelines);
        }
    }
}