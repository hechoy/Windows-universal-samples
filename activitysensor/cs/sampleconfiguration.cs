//*********************************************************
//
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the Microsoft Public License.
// THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
// IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
// PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
//
//*********************************************************

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using ActivitySensorCS;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "ActivitySensorCS";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title = "Current activity", ClassType = typeof(Scenario1_CurrentActivity) },
            new Scenario() { Title = "Activity history", ClassType = typeof(Scenario2_History) },
            new Scenario() { Title = "Events", ClassType = typeof(Scenario3_ChangeEvents) },
            new Scenario() { Title = "Background activity", ClassType = typeof(Scenario4_BackgroundActivity) },
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
