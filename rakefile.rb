
task :create_setup, [:product_version, :configuration] => [:load_dependencies] do |t, args|
	solution_dir = File.dirname(__FILE__)
	setup_dir = File.join(solution_dir, 'setup')
	src_dir = File.join(solution_dir, 'src', 'ConsoleApp', 'bin', args.configuration)
	deploy_dir = File.join(setup_dir, 'deploy');
	product_name = 'ConsoleApp'
	product_version = args.product_version

	Rake::Task['setup:create'].execute(OpenStruct.new(
		:src_dir => src_dir, 
		:setup_dir => setup_dir,  
		:deploy_dir => deploy_dir, 
		:product_name => product_name, 
		:product_version => product_version))
end

desc "Ensure that all required files are loaded"
task :load_dependencies do
  packages_rb_files = File.join('.','packages',  'SBSuite.setup-scripts*','**', '*.rb')
  Dir.glob(packages_rb_files).each{|x|  require_relative x}
end