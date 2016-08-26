﻿namespace TemplateGenerator
{
    partial class Extension
    {
        private readonly string _assemblyName;
        private readonly string _singleName = "";
        private readonly string _pluralName = "";
        private readonly bool _tenantRequired = false;
        private   int _recCount = 0;

        public Extension(string assemblyName, string singleName, string pluralName, bool tenantRequired)
        {
            _assemblyName = assemblyName;
            _singleName = singleName;
            _pluralName = pluralName;
            _tenantRequired = tenantRequired;
            _recCount = 0;
        }
    }
}