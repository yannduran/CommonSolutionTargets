﻿/*
 * Copyright (c) 2013-2014  Denis Kuzmin (reg) <entry.reg@gmail.com>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using Microsoft.VisualStudio;

namespace CommonSolutionTargets
{
    /// <summary>
    /// Represents available types of the build for any actions
    /// 
    /// *!* be careful with intersection
    ///     Scope of:
    ///      * {5EFC7975-14BC-11CF-9B2B-00AA00573819}
    ///      * {1496A755-94DE-11D0-8C3F-00C04FC2AAE2}
    /// </summary>
    public enum BuildType
    {
        /// <summary>
        /// 'build' action
        /// </summary>
        Build = VSConstants.VSStd97CmdID.BuildSln,
        /// <summary>
        /// 'rebuild' action
        /// </summary>
        Rebuild = VSConstants.VSStd97CmdID.RebuildSln,
        /// <summary>
        /// 'clean' action
        /// </summary>
        Clean = VSConstants.VSStd97CmdID.CleanSln,
        /// <summary>
        /// 'deploy' action
        /// </summary>
        Deploy = VSConstants.VSStd97CmdID.DeploySln,
        /// <summary>
        /// 'Start Debugging' action
        /// </summary>
        Start = VSConstants.VSStd97CmdID.Start,
        /// <summary>
        /// 'Start Without Debugging' action
        /// </summary>
        StartNoDebug = VSConstants.VSStd97CmdID.StartNoDebug,

        /// <summary>
        /// 'build' action for selection
        /// </summary>
        BuildSelection = VSConstants.VSStd97CmdID.BuildSel,
        /// <summary>
        /// 'rebuild' action for selection
        /// </summary>
        RebuildSelection = VSConstants.VSStd97CmdID.RebuildSel,
        /// <summary>
        /// 'clean' action for selection
        /// </summary>
        CleanSelection = VSConstants.VSStd97CmdID.CleanSel,
        /// <summary>
        /// 'deploy' action for selection
        /// </summary>
        DeploySelection = VSConstants.VSStd97CmdID.DeploySel,

        /// <summary>
        /// 'build' action for project
        /// </summary>
        BuildOnlyProject = VSConstants.VSStd2KCmdID.BuildOnlyProject,
        /// <summary>
        /// 'rebuild' action for project
        /// </summary>
        RebuildOnlyProject = VSConstants.VSStd2KCmdID.RebuildOnlyProject,
        /// <summary>
        /// 'clean' action for project
        /// </summary>
        CleanOnlyProject = VSConstants.VSStd2KCmdID.CleanOnlyProject,

        /// <summary>
        /// 'build' action for project
        /// </summary>
        BuildCtx = VSConstants.VSStd97CmdID.BuildCtx,
        /// <summary>
        /// 'rebuild' action for project
        /// </summary>
        RebuildCtx = VSConstants.VSStd97CmdID.RebuildCtx,
        /// <summary>
        /// 'clean' action for project
        /// </summary>
        CleanCtx = VSConstants.VSStd97CmdID.CleanCtx,
        /// <summary>
        /// 'deploy' action for project
        /// </summary>
        DeployCtx = VSConstants.VSStd97CmdID.DeployCtx,

        /// <summary>
        /// 'Compile' action
        /// </summary>
        Compile = VSConstants.VSStd2KCmdID.COMPILE,
        /// <summary>
        /// 'Link only' action
        /// </summary>
        LinkOnly = VSConstants.VSStd2KCmdID.LINKONLY,
        /// <summary>
        /// 'Publish' action for selection
        /// </summary>
        PublishSelection = VSConstants.VSStd2KCmdID.ECMD_PUBLISHSELECTION,

        /// <summary>
        /// Common context
        /// </summary>
        Common = Int32.MaxValue
    }
}
