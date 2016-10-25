// Copyright 2016 Jan Boehmer
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDBatchToolsHelper
{
    public class Sbsbaker : IBatchTool
    {

        public enum Modes
        {
            unset,
            ambient_occlusion,
            ambient_occlusion_from_mesh,
            bent_normal_from_mesh,
            color_from_mesh,
            curvature,
            height_from_mesh,
            normal_from_mesh,
            normal_world_space,
            opacity_mask_from_mesh,
            position,
            texture_from_mesh,
            thickness_from_mesh,
            uv_map,
            world_space_direction
        }

        public Sbsbaker()
        {

        }

        public string getCmdLine()
        {
            String s = getToolname();

            return s.Trim();
        }

        public string getToolname()
        {
            if (Environment.OSVersion.Platform == PlatformID.Unix
                || Environment.OSVersion.Platform == PlatformID.MacOSX)
                return "sbsbaker";
            else
                return "sbsbaker.exe";
        }

        public string getVersionCmd()
        {
            return getToolname() + "--version";
        }

        public string getHelpCmd()
        {
            return getToolname() + "--help";
        }

    }
}
