using System.Drawing;
using CounterStrikeSharp.API.Core;
using CS2_CustomTrailAndTracers.Managers;
using CS2_CustomTrailAndTracers.Utils;

namespace CS2_CustomTrailAndTracers;

public class CS2_CustomTrailAndTracers : BasePlugin
{
    public override string ModuleName => "CS2-CustomTrailAndTracers Colored";

    public override string ModuleVersion => "0.0.3";
    public override string ModuleAuthor => "Letaryat | https://github.com/Letaryat";
    public readonly string[] projectiles = ["hegrenade_projectile", "flashbang_projectile", "smokegrenade_projectile", "decoy_projectile", "molotov_projectile"];

    public readonly string[] modelParticles = [
        "particles/letaryat_proper/grenadetrail_black.vpcf", //0
        "particles/letaryat_proper/grenadetrail_red.vpcf",
        "particles/letaryat_proper/grenadetrail_green.vpcf",
        "particles/letaryat_proper/grenadetrail_blue.vpcf",
        "particles/letaryat_proper/grenadetrail_violet.vpcf",
        "particles/letaryat_proper/grenadecracktrail_black.vpcf", // 5
        "particles/letaryat_proper/grenadecracktrail_red.vpcf",
        "particles/letaryat_proper/grenadecracktrail_green.vpcf",
        "particles/letaryat_proper/grenadecracktrail_blue.vpcf",
        "particles/letaryat_proper/grenadecracktrail_violet.vpcf",
    ];

    public readonly string[] tracerParticles = [
        "particles/letaryat_tracers/bullet_tracer.vpcf",
        "particles/letaryat_tracers/bullet_tracer1.vpcf", 
        "particles/letaryat_tracers/bullet_tracer_crack.vpcf", 
        "particles/letaryat_tracers/bullet_tracer_electric.vpcf", 
        "particles/letaryat_tracers/bullet_tracer_water.vpcf", 
        "particles/letaryat_tracers/bullettracerosiem.vpcf",
        "particles/letaryat_tracers/bullet_tracer_electricradius.vpcf",
    ];
    public int modelToUse = 0;
    public int tracerToUse = 0;
    public Color TrailColor = Color.FromArgb(255, 87, 216, 128);

    //Managers:
    public EventManager? EventManager { get; private set; }
    public CommandsManager? CommandsManager { get; private set; }

    public PluginUtilities? PluginUtilties { get; private set; }

    public override void Load(bool hotReload)
    {
        Console.WriteLine("CS2-CustomTrailAndTracers Colored Loaded");
        //Managers
        EventManager = new EventManager(this);
        CommandsManager = new CommandsManager(this);
        PluginUtilties = new PluginUtilities(this);

        //Register:
        EventManager.RegisterEvents();
        CommandsManager.RegisterCommands();
    }

    public override void Unload(bool hotReload)
    {
        Console.WriteLine("CS2-CustomTrailAndTracers Colored Unloaded!");
    }

}