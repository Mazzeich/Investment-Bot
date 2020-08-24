IsRun = true

function  OnInit()
  message("Bot is running...")
end

function OnStop()
  message("Bot has been suspended.")
end

function isConnected()
  message("Client is connected to the server")
end

tbl_portfolio = getPortfolioInfo("MC0002500000","4T1RE")

function main()
  --Проверяем, можем ли мы вообще работать с Quik
  if(isConnected) then
    message("Client is connected to the server")
  else
    message("Client can not connect to the server")
  end
  
  --Запишем в файл информацию о портфеле
  local fileName = "X:\\Coding\\C#\\Investment-Bot\\invest-info.txt"
  local fileWrite
  fileWrite = io.open(fileName, "w")
    
  fileWrite:write("[All assets]:\t"   .. tbl_portfolio.all_assets      .. "\n" ..
                  "[Assets]:\t"       .. tbl_portfolio.assets          .. "\n" ..
                  "[P/L]:\t\t"        .. tbl_portfolio.profit_loss     .. "\n" ..
                  "[Total money]:\t"  .. tbl_portfolio.total_money_bal 
                  )
  fileWrite:close()
  
end
