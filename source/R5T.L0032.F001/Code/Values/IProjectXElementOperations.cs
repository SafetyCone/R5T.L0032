using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using R5T.T0131;


namespace R5T.L0032.F001
{
    [ValuesMarker]
    public partial interface IProjectXElementOperations : IValuesMarker
    {
        public Action<XElement> In_NewItemGroupXElementContext(
            IEnumerable<Action<XElement>> itemGroupActions) =>
            projectElement => Instances.ProjectXElementOperator.In_NewItemGroupXElementContext(
                projectElement,
                itemGroupActions);

        public Action<XElement> In_NewItemGroupXElementContext(
            params Action<XElement>[] itemGroupActions)
        {
            return this.In_NewItemGroupXElementContext(
                itemGroupActions.AsEnumerable());
        }

        public Action<XElement> In_NewPropertyGroupXElementContext(
            IEnumerable<Action<XElement>> propertyGroupActions) =>
            projectElement => Instances.ProjectXElementOperator.In_NewPropertyGroupXElementContext(
                projectElement,
                propertyGroupActions);

        public Action<XElement> In_NewPropertyGroupXElementContext(
            params Action<XElement>[] propertyGroupActions)
        {
            return this.In_NewPropertyGroupXElementContext(
                propertyGroupActions.AsEnumerable());
        }

        /// <inheritdoc cref="Z001.IProjectSdkNames.NET"/>
        public Action<XElement> Set_SDK_Default =>
            projectElement => Instances.ProjectXElementOperator.Set_Sdk(
                projectElement,
                Instances.ProjectSdkNames.NET);

        /// <inheritdoc cref="Z001.IProjectSdkNames.NET"/>
        public Action<XElement> Set_SDK_NET =>
            projectElement => Instances.ProjectXElementOperator.Set_Sdk(
                projectElement,
                Instances.ProjectSdkNames.NET);
    }
}
