// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;
using System;
using EpicGames.Core;

public class TPSEditorTarget : TargetRules
{
    [CommandLine("-UnoptimizedCode")]
    public bool UnoptimizedCode = false;

    public TPSEditorTarget(TargetInfo Target) : base(Target)
    {
        // Console.WriteLine("TPS editor target ---------------->");
        // Console.WriteLine("TPSEditorTarget UnoptimizedCode ----------------> {0}", UnoptimizedCode);
        if (UnoptimizedCode)
        {
            ProjectDefinitions.Add("UNOPTIMIZED_CODE");
        }

        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V2;
        ExtraModuleNames.Add("TPS");
    }
}
